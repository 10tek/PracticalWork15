using System;
using System.Reflection;

namespace PW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assemblyString = typeof(String).Assembly;
            string text = "Eazy HW, sir";
            foreach (var type in assemblyString.GetTypes())
            {
                if (type.Name == "String")
                {
                    foreach (var method in type.GetMethods())
                    {
                        if (method.ToString() == "System.String Substring(Int32, Int32)")
                        {
                            var result = method.Invoke(text, new object[] { 5,2 }).ToString();
                            Console.WriteLine(result);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

//var method = type.GetMethod("System.String Substring(Int32)");
//var result = method.Invoke(text, new object[] { 2 }).ToString();
//Console.WriteLine(result);

