namespace Jedi.HierarchyBuilder.Utils.Binder.Validators
{
    public interface IBinderValidator<in TResult>
    {
        bool IsValid(TResult value);
    }
}
