using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var theList = Assembly.Load("For_IS_18_02.BL").GetTypes().ToList();
            Print(theList);

            var metod = Type.GetType("For_IS_18_02.BL.ClassMayBe", false, true);

            foreach (MethodInfo method in metod.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                //получаем все параметры

                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
        }



        private static void Print(IEnumerable theList)
        {
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
