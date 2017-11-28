using System.Windows.Forms;
using System.Collections.Generic;
using Jedi.HierarchyBuilder.Utils.Binder.Validators;

namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public interface IBinder
    {
        /// <summary>
        /// Sets the binded entity in the UI
        /// </summary>
        void Set();
    }

    public interface IBinder<TResult> : IBinder, IBinderActions<TResult>
    {
        /// <summary>
        /// Validators which will check if inputed data from the binder will be applied over the entity that is binded
        /// </summary>
        ICollection<IBinderValidator<TResult>> Validators { get; }
        
        /// <summary>
        /// Bind control to the binder
        /// </summary>
        /// <typeparam name="TControl">Control type</typeparam>
        /// <param name="control">Control which will bind</param>
        void Bind<TControl>(TControl control) where TControl : Control;

        /// <summary>
        /// Unbind control to the binder
        /// </summary>
        /// <typeparam name="TControl">Control type</typeparam>
        /// <param name="control">Control which will unbounded</param>
        void Unbind<TControl>(TControl control) where TControl : Control;
    }
}
