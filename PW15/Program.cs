using System;
using System.Collections.Generic;
using System.Reflection;

namespace PW15
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = typeof(String).Assembly;
            string text = "Eazy HW, sir";
            foreach (var type in assembly.GetTypes())
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

            assembly = typeof(List<string>).Assembly;
            foreach (var type in assembly.GetTypes())
            {
                foreach (var constructor in type.GetConstructors())
                {
                    Console.WriteLine(constructor);
                }
            }

            Console.ReadKey();
        }
    }
}

//var method = type.GetMethod("System.String Substring(Int32)");
//var result = method.Invoke(text, new object[] { 2 }).ToString();
//Console.WriteLine(result);

