using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jedi.HierarchyBuilder.Utils.Binder.Validators;

namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public abstract class Binder<TSource, TResult> : IBinder<TResult>, IBinderSettable<TResult>, IBinderInformable
    {
        #region Fields

        private readonly Func<TSource> _entity;
        private readonly Expression<Func<TSource, TResult>> _result;
        private ICollection<IBinderValidator<TResult>> _validators;
        private bool _showToolTip;

        protected readonly Guid Id;

        #endregion

        #region Properties

        /// <summary>
        /// Internal flag used when Set method is invoked
        /// </summary>
        protected bool InternalSet { get; set; }
        
        #endregion

        #region Implementation of IBinderActions<out TResult>

        /// <inheritdoc />
        public event ValueChangedHandler<TResult> OnChanged;

        #endregion

        #region Constructors

        private Binder()
        {
            _validators = new List<IBinderValidator<TResult>>();
            _showToolTip = false;
            Id = Guid.NewGuid();
        }

        protected Binder(Func<TSource> entity, Expression<Func<TSource, TResult>> result)
            : this()
        {
            if(entity == null)
                throw new ArgumentNullException(nameof(entity));

            if(result == null)
                throw new ArgumentNullException(nameof(result));

            _entity = entity;
            _result = result;
        }

        #endregion

        #region Implementation of IBinder<TResult>

        /// <inheritdoc />
        public virtual ICollection<IBinderValidator<TResult>> Validators
        {
            get
            {
                return _validators;
            }
            protected set
            {
                _validators = value;
            }
        }

        /// <inheritdoc />
        public abstract void Bind<TControl>(TControl control)
            where TControl : Control;

        /// <inheritdoc />
        public abstract void Unbind<TControl>(TControl control)
            where TControl : Control;

        /// <inheritdoc />
        public abstract void Set();

        #endregion

        #region Implementation of IBinderSettable<TResult>

        /// <inheritdoc />
        public virtual void SetValue(TResult value)
        {
            BindValueToProperty(value);
        }

        #endregion

        #region Implementation of IBinderInformable

        public virtual bool ShowToolTip
        {
            get
            {
                return _showToolTip;
            }
            set
            {
                _showToolTip = value;
            }
        }

        #endregion

        #region Overrides of Object

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj != null && obj.GetHashCode() == GetHashCode();
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        #endregion

        #region Protected methods

        /// <summary>
        /// Set value to the property of the bounded entity
        /// </summary>
        /// <param name="value">New value</param>
        protected virtual void BindValueToProperty(TResult value)
        {
            if(InternalSet)
                return;

            var entity = _entity();

            //                      if validators will permit
            if (entity != null && (Validators?.All(v => v.IsValid(value)) ?? true))
            {
                ReflexionEx.SetPropertyValue(entity, value, _result);

                if (OnChanged != null)
                {
                    var property = ReflexionEx.GetPropertyInfo(_result);
                    var args = new BinderValueChangedArgs<TResult>(value, property.Name);
                    OnChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Gets the value of the entities property 
        /// </summary>
        /// <returns>The existing value</returns>
        [Pure]
        protected virtual TResult GetResultOfEntity()
        {
            var entity = _entity();

            if (entity == null)
                return default(TResult);

            return (TResult)ReflexionEx.GetPropertyValue(entity, _result);
        }

        #endregion
    }
}
