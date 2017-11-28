using System;
using System.Reflection;
using System.Linq.Expressions;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class ReflexionEx
    {
        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
        {
            Type type = typeof(TSource);

            MemberExpression member = propertyLambda.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException($"Expression '{propertyLambda}' refers to a method, not a property.");

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
                throw new ArgumentException($"Expression '{propertyLambda}' refers to a field, not a property.");

            if (propInfo.ReflectedType != null && type != propInfo.ReflectedType && !type.IsSubclassOf(propInfo.ReflectedType))
                throw new ArgumentException($"Expresion '{propertyLambda}' refers to a property that is not from type {type}.");

            return propInfo;
        }

        public static object GetValue(this object obj, string propertyName)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if(string.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException(nameof(propertyName));

            var type = obj.GetType();

            var propInfo = type.GetProperty(propertyName);

            if(propInfo == null)
                throw new Exception("Property not found");

            return propInfo.GetValue(obj);
        }

        public static TResult GetValue<TResult>(this object obj, string propertyName)
        {
            var result = GetValue(obj, propertyName);

            if (result is TResult)
                return (TResult) result;

            throw new Exception("Type mismatch");
        }
    }
}
