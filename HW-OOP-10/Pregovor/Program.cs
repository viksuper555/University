using System;
using System.Linq;
using System.Reflection;

namespace Pregovor
{
    class Program
    {      
        static void Main(string[] args)
        {
            var num = "123".ParseTo<int>();


            var myList = new MyList<int>();

            myList.Add(1);
            myList.Add(3);
            myList.Add(5);
            myList.Add(7);
            myList.Add(9);

            var text = myList.ToStringEx();
        }
    }
    
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    class ToStringExAttribute : Attribute
    {

    }

    class MyList<T>
    {
        private T[] _array = new T[1];

        [ToStringEx]
        private int _lastIdx = 0;

        public void Add(T element)
        {
            if(_array.Length <= _lastIdx)
            {
                T[] tempArray = new T[_array.Length * 2];

                Array.Copy(_array, tempArray, _lastIdx);

                _array = tempArray;                
            }
            _array[_lastIdx++] = element;
        }

    }

    static class Extensions
    {
        public static string ToStringEx(this object obj)
        {
            return obj.GetType()
               .GetMembers(BindingFlags.NonPublic | BindingFlags.Instance)
               .Where(m => m.GetCustomAttribute(typeof(ToStringExAttribute)) != null)
               .Select(mi => mi is PropertyInfo pInfo ? pInfo.GetValue(obj) :
               mi is FieldInfo fInfo ? fInfo.GetValue(obj) :
               "")
               .Select(v => v.ToString())
               .Aggregate((f,s) => f + "; " + s);
        }

        public static T ParseTo<T>(this string text)
        {
            var methodInfo = typeof(T)
                .GetMethods(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public)
                .Where(mi => mi.Name == "Parse")
                .Select(mi => new
                {
                    MethodInfo = mi,
                    Parameters = mi.GetParameters()
                })
                .Where(mi => mi.Parameters.Count() == 1
                && mi.Parameters.Single().ParameterType == typeof(string))
                .SingleOrDefault()?.MethodInfo;

            if (methodInfo != null)
                return (T)methodInfo.Invoke(null, new[] { text });
            else
                throw new NotSupportedException();
        }
    }
}
