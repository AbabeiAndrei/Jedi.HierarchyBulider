using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Utils.Binder.Specific
{
    public class NumericBinder<TSource> : Binder<TSource, int>
    {
        #region Fields

        private NumericUpDown _numericUpDown;

        #endregion

        #region Constructors

        public NumericBinder(Func<TSource> entity, Expression<Func<TSource, int>> result) 
            : base(entity, result)
        {
        }

        #endregion

        #region Overrides of Binder<TSource,bool>

        public override void Bind<TControl>(TControl control)
        {
            if (_numericUpDown != null)
                throw new BinderAlreadyInUseException();

            var nud = control as NumericUpDown;

            if (nud == null)
                throw new ArgumentException("Argument must be a numericUpDown", nameof(control));

            nud.ValueChanged += BindValueToProperty;

            _numericUpDown = nud;

            BindValueToProperty((int) nud.Value);
        }

        public override void Unbind<TControl>(TControl control)
        {
            var nud = control as NumericUpDown;

            if (nud == null)
                throw new ArgumentException("Argument must be a numericUpDown", nameof(control));

            nud.ValueChanged -= BindValueToProperty;
        }

        public override void Set()
        {
            try
            {
                InternalSet = true;

                if (_numericUpDown == null)
                    throw new BinderNotAssignedException();

                _numericUpDown.Value = GetResultOfEntity();
            }
            finally
            {
                InternalSet = false;
            }
        }

        public override void SetValue(int value)
        {
            if (_numericUpDown == null)
                throw new BinderNotAssignedException();

            _numericUpDown.Value = value;
        }

        #endregion

        #region Private methods

        private void BindValueToProperty(object sender, EventArgs e)
        {
            var nud = sender as NumericUpDown;

            if (nud == null)
                return;

            BindValueToProperty((int) nud.Value);
        }


        #endregion
    }
}
