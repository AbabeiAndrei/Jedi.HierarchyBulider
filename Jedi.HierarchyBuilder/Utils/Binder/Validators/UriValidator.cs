using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils.Binder.Validators
{
    public class UriValidator : IBinderValidator<string>
    {
        #region Implementation of IBinderValidator<in TResult>

        public bool IsValid(string value)
        {
            Uri uri;
            return Uri.TryCreate(value, UriKind.RelativeOrAbsolute, out uri);
        }

        #endregion
    }
}
