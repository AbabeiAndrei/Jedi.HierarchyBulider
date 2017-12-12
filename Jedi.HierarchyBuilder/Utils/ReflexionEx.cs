using System;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;

namespace Jedi.HierarchyBuilder.Utils
{
    public static class ReflexionEx
    {
        public static PropertyInfo GetPropertyInfo<TSource, TProperty>(Expression<Func<TSource, TProperty>> propertyLambda)
        {
            MemberExpression member = propertyLambda.Body as MemberExpression;
            if (member == null)
                throw new ArgumentException($"Expression '{propertyLambda}' refers to a method, not a property.");

            PropertyInfo propInfo = member.Member as PropertyInfo;
            if (propInfo == null)
                throw new ArgumentException($"Expression '{propertyLambda}' refers to a field, not a property.");
            
            return propInfo;
        }
        
        public static object GetPropertyValue<TSource, TProperty>(object obj, Expression<Func<TSource, TProperty>> propertyLambda)
        {
            foreach (var prop in propertyLambda.ToString().Split('.').Skip(1).Select(s => obj.GetType().GetProperty(s)))
            {
                if(prop == null)
                    throw new AggregateException($"Incorect path of expresion {propertyLambda}");

                obj = prop.GetValue(obj, null);
            }

            return obj;
        }

        public static void SetPropertyValue<TSource, TProperty>(object obj, TProperty value, Expression<Func<TSource, TProperty>> propertyLambda)
        {

            var properties = propertyLambda.ToString().Split('.').Skip(1).ToArray();
            for (int i = 0; i < properties.Length - 1; i++)
            {
                var prop = obj.GetType().GetProperty(properties[i]);

                if (prop == null)
                    throw new AggregateException($"Incorect path of expresion {propertyLambda}");

                obj = prop.GetValue(obj, null);
            }

            var propertyToSet = GetPropertyInfo(propertyLambda);

            if (propertyToSet != null)
                propertyToSet.SetValue(obj, value, null);
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
