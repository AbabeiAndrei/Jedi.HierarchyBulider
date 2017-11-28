using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Utils.Binder.Specific
{
    public class ComboboxBinder<TSource, TResult> : Binder<TSource, TResult>
    {
        #region Fields

        private ComboBox _comboBox;

        #endregion

        #region Constructors

        public ComboboxBinder(Func<TSource> entity, Expression<Func<TSource, TResult>> result) 
            : base(entity, result)
        {
        }

        #endregion

        #region Overrides of Binder<TSource,bool>

        public override void Bind<TControl>(TControl control)
        {
            if (_comboBox != null)
                throw new BinderAlreadyInUseException();

            var cb = control as ComboBox;

            if (cb == null)
                throw new ArgumentException("Argument must be a comboBox", nameof(control));

            cb.SelectedIndexChanged += BindValueToProperty;

            _comboBox = cb;

            BindValueToProperty(cb.GetSelectedValue<TResult>());
        }

        public override void Unbind<TControl>(TControl control)
        {
            var cb = control as ComboBox;

            if (cb == null)
                throw new ArgumentException("Argument must be a comboBox", nameof(control));

            cb.SelectedIndexChanged -= BindValueToProperty;
        }

        public override void Set()
        {
            try
            {
                InternalSet = true;

                if (_comboBox == null)
                    throw new BinderNotAssignedException();

                _comboBox.SetSelectedValue(GetResultOfEntity());
            }
            finally
            {
                InternalSet = false;
            }
        }

        public override void SetValue(TResult value)
        {
            if (_comboBox == null)
                throw new BinderNotAssignedException();

            _comboBox.SetSelectedValue(value);
        }

        #endregion

        #region Private methods

        private void BindValueToProperty(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb == null)
                return;

            BindValueToProperty(cb.GetSelectedValue<TResult>());
        }


        #endregion
    }
}
