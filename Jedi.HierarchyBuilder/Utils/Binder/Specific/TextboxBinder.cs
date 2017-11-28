using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Utils.Binder.Specific
{
    public class TextboxBinder<TSource> : Binder<TSource, string>
    {
        #region Fields

        private TextBox _textBox;
        
        #endregion

        #region Constructors

        public TextboxBinder(Func<TSource> entity, Expression<Func<TSource, string>> result) 
            : base(entity, result)
        {

        }
        
        #endregion

        #region Overrides of Binder<TSource,TResult>

        public override void Bind<TControl>(TControl control)
        {
            if (_textBox != null)
                throw new BinderAlreadyInUseException();

            var txt = control as TextBox;

            if(txt == null)
                throw new ArgumentException("Argument must be a textBox", nameof(control));

            txt.TextChanged += BindValueToProperty;

            _textBox = txt;

            BindValueToProperty(txt.Text);
        }

        public override void Unbind<TControl>(TControl control)
        {
            var txt = control as TextBox;

            if (txt == null)
                throw new ArgumentException("Argument must be a textBox", nameof(control));

            txt.TextChanged -= BindValueToProperty;
        }

        public override void Set()
        {
            try
            {
                InternalSet = true;

                if (_textBox == null)
                    throw new BinderNotAssignedException();

                _textBox.Text = GetResultOfEntity();
            }
            finally
            {
                InternalSet = false;
            }
        }

        public override void SetValue(string value)
        {
            if(_textBox == null)
                throw new BinderNotAssignedException();

            _textBox.Text = value;
        }

        #endregion

        #region Private methods

        private void BindValueToProperty(object sender, EventArgs e)
        {
            var txt = sender as TextBox;

            if (txt == null)
                return;

            BindValueToProperty(txt.Text);
        }

        #endregion
    }
}
