namespace Jedi.HierarchyBuilder.Utils.Binder
{
    public interface IBinderSettable<in TResult>
    {
        /// <summary>
        /// Set value for the property of an entity which is bounded
        /// </summary>
        /// <param name="value"></param>
        void SetValue(TResult value);
    }
}
