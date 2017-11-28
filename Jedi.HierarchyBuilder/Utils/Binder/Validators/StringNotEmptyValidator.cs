using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils.Binder.Validators
{
    public class StringNotEmptyValidator : IBinderValidator<string>
    {
        #region Fields

        private readonly bool _checkWhiteSpace;

        #endregion

        #region Constructors

        public StringNotEmptyValidator(bool checkWhiteSpace)
        {
            _checkWhiteSpace = checkWhiteSpace;
        }

        #endregion

        #region Implementation of IBinderValidator<in string>

        public bool IsValid(string value)
        {
            return !(_checkWhiteSpace
                       ? string.IsNullOrWhiteSpace(value)
                       : string.IsNullOrEmpty(value));
        }

        #endregion
    }
}
