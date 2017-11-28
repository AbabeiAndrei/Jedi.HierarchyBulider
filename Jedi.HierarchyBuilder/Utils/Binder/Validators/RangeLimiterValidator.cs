using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi.HierarchyBuilder.Utils.Binder.Validators
{
    public class RangeLimiterValidator : IBinderValidator<int>
    {
        #region Fields

        private readonly int _min;
        private readonly int _max;

        #endregion

        #region Constructors

        public RangeLimiterValidator(int min, int max)
        {
            _min = min;
            _max = max;
        }

        #endregion

        #region Implementation of IBinderValidator<in int>

        public bool IsValid(int value)
        {
            return _min <= value && value <= _max;
        }

        #endregion
    }
}
