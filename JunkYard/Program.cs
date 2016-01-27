using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Tuple<Type, object>> dict = new Dictionary<string, Tuple<Type, object>>();

            MyClass cls = new MyClass();
            cls.Id = Guid.NewGuid();
            cls.Name = "Some name";

            dict.Add("key1", Tuple.Create(typeof(string), (object)"value1"));
            dict.Add("key2", Tuple.Create(typeof(MyClass), (object)cls));

            Type t = dict["key1"].Item1;
            dynamic key1value = dict["key1"].Item2;
            dynamic key2value = dict["key2"].Item2;
            Console.WriteLine(key1value.GetType());
            Console.WriteLine(key1value);
            Console.WriteLine(key2value.GetType());
            Console.WriteLine(key2value);
            Console.ReadKey();
        }
    }

    public class MyClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
