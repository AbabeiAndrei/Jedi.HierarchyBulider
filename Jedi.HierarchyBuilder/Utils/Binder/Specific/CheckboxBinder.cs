using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Utils.Binder.Specific
{
    public class CheckboxBinder<TSource> : Binder<TSource, bool>
    {
        #region Fields

        private CheckBox _checkBox;

        #endregion

        #region Constructors

        public CheckboxBinder(Func<TSource> entity, Expression<Func<TSource, bool>> result) 
            : base(entity, result)
        {
        }

        #endregion

        #region Overrides of Binder<TSource,bool>

        public override void Bind<TControl>(TControl control)
        {
            if (_checkBox != null)
                throw new BinderAlreadyInUseException();

            var chk = control as CheckBox;

            if (chk == null)
                throw new ArgumentException("Argument must be a checkBox", nameof(control));

            chk.CheckedChanged += BindValueToProperty;

            _checkBox = chk;

            BindValueToProperty(chk.Checked);
        }

        public override void Unbind<TControl>(TControl control)
        {
            var chk = control as CheckBox;

            if (chk == null)
                throw new ArgumentException("Argument must be a checkBox", nameof(control));

            chk.CheckedChanged -= BindValueToProperty;
        }

        public override void Set()
        {
            try
            {
                InternalSet = true;

                if (_checkBox == null)
                    throw new BinderNotAssignedException();

                _checkBox.Checked = GetResultOfEntity();
            }
            finally
            {
                InternalSet = false;
            }
        }

        public override void SetValue(bool value)
        {
            if (_checkBox == null)
                throw new BinderNotAssignedException();

            _checkBox.Checked = value;
        }

        #endregion

        #region Private methods

        private void BindValueToProperty(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;

            if (chk == null)
                return;

            BindValueToProperty(chk.Checked);
        }


        #endregion
    }
}
