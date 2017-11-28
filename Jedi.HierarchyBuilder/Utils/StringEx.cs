namespace Jedi.HierarchyBuilder.Utils
{
    public static class StringEx
    {
        public static string DefaultIfNull(this string text, string @default)
        {
            return string.IsNullOrEmpty(text) ? @default : text;
        }
    }
}
