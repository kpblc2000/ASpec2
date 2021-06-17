using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ASpecCore.Infrastructure
{
    public static class ObjectExtensions
    {
        public static T Clone<T>(this T entity) where T : class
        {
            var clone = Activator.CreateInstance(entity.GetType());
            var entPropValueDict = entity.AsPropValueDictionary();
            foreach (var prop in clone.GetType().GetProperties())
            {
                clone.GetType().GetProperty(prop.Name).SetValue(clone, entPropValueDict[prop.Name]);
            }
            return clone as T;
        }

        public static IDictionary<string, object> AsPropValueDictionary<T>(this T instance, params BindingFlags[] bindingFlags)
        {
            var runtimeBindFlags = BindingFlags.Default;
            if (bindingFlags.Count() == 0)
            {
                runtimeBindFlags = BindingFlags.Default;
            }
            else if (bindingFlags.Count() == 1)
            {
                runtimeBindFlags = bindingFlags[0];
            }
            else
            {
                runtimeBindFlags = bindingFlags.Aggregate(runtimeBindFlags, (current, bindingFlag) => current | bindingFlag);
            }

            return runtimeBindFlags == BindingFlags.Default
                ? instance.GetType().GetProperties().ToDictionary(prop => prop.Name, prop => prop.GetValue(instance))
                : instance.GetType().GetProperties(runtimeBindFlags).ToDictionary(prop => prop.Name, prop => prop.GetValue(instance));

        }
    }

}
