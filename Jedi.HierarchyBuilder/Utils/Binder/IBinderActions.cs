namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public delegate void ValueChangedHandler<TResult>(IBinder sender, BinderValueChangedArgs<TResult> args);

    public interface IBinderActions<TResult>
    {
        /// <summary>
        /// Event which will be triggered when a bound countrol will change the value of an entity property
        /// </summary>
        event ValueChangedHandler<TResult> OnChanged;
    }

    public class BinderValueChangedArgs<TResult>
    {
        /// <summary>
        /// Property which is affected
        /// </summary>
        public string Property { get; }

        /// <summary>
        /// The new value
        /// </summary>
        public TResult Value { get; }

        public BinderValueChangedArgs(TResult value, string property)
        {
            Value = value;
            Property = property;
        }
    }
}
