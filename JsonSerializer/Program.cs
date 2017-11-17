using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonSerializer
{
    public class Program
    {
        public static string listToJson(List<Object> list)
        {
            string jsonStr = "[";
            
            foreach (var p in list)
            {
                jsonStr += "{";
                Type t = p.GetType();
                PropertyInfo[] props = t.GetProperties();
                foreach (var prop in props)
                {
                    jsonStr += "\"" + prop.Name;
                    if (prop.GetValue(p).GetType() == typeof(string))
                    {
                        jsonStr += "\":\"" + prop.GetValue(p) + "\"";
                    }
                    else
                    {
                        jsonStr += "\":" + prop.GetValue(p) + "";
                    }
                    if (!prop.Equals(props[props.Length - 1]))
                    {
                        jsonStr += ",";
                    }
                }
                jsonStr += "}";
                if (!p.Equals(list[list.Count - 1]))
                {
                    jsonStr += ",";
                }
            }
            jsonStr += "]";

            return jsonStr;
        }
        static void Main(string[] args)
        {
            List<Object> list = new List<Object>();
            list.Add(new Person(1, "Sam", "Smith", 60));
            list.Add(new Person(2, "John", "Doe", 30));

            Console.WriteLine(listToJson(list));
            Console.WriteLine(JsonConvert.SerializeObject(list));
        }
    }
}
