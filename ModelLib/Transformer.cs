using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public static class Transformer
    {
        public static List<V> TransformObjects<T, V>(List<T> objects, Func<T, V> transformer)
        {
            List<V> transformedObjects = new List<V>();
            foreach (T obj in objects)
            {
                V transformedItem = transformer(obj);
                transformedObjects.Add(transformedItem);
            }
            return transformedObjects;
        }
    }
}
