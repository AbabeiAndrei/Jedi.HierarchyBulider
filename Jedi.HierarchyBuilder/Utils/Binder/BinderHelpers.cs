using System;
using System.Windows.Forms;
using Jedi.HierarchyBuilder.Utils.Binder.Validators;

namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public static class BinderHelpers
    {
        public static IBinder<TResult> AfterChange<TResult>(this IBinder<TResult> binder, Action<TResult> onChange)
        {
            if(binder == null)
                throw new ArgumentNullException(nameof(binder));

            if(onChange == null)
                throw new ArgumentNullException(nameof(onChange));

            binder.OnChanged += (sender, args) => onChange(args.Value);

            return binder;
        }

        public static IBinder<TResult> Validate<TResult>(this IBinder<TResult> binder, IBinderValidator<TResult> validator)
        {
            if (binder == null)
                throw new ArgumentNullException(nameof(binder));

            if (validator == null)
                throw new ArgumentNullException(nameof(validator));

            binder.Validators.Add(validator);

            return binder;
        }

        public static IBinder<TResult> IsThroughProxy<TResult>(this IBinder<TResult> binder)
        {
            if (binder == null)
                throw new ArgumentNullException(nameof(binder));

            return binder;
        }
        
        public static IBinder<TResult> SetValue<TResult>(this IBinder<TResult> binder, TResult value)
        {
            var bind = binder as IBinderSettable<TResult>;

            if (bind == null)
                throw new BinderNotSupportSetters();

            bind.SetValue(value);

            return binder;
        }

        public static IBinder SetValue(this IBinder binder, object value)
        {
            var type = binder.GetType();

            if(type == null)
                throw new TypeAccessException();

            var method = type.GetMethod(nameof(IBinderSettable<object>.SetValue));

            if(method == null)
                throw new MethodAccessException();

            method.Invoke(binder, new [] {value});

            return binder;
        }
        
    }
}
