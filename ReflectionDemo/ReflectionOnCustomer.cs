using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
  class ReflectionOnCustomer
    {

        public static void test()
        {
           
          Type type= Type.GetType("ReflectionDemo.CustomerInfo");
         

            Console.WriteLine("\nFull name is " + type.FullName);
            Console.WriteLine("\nClass name is " + type.Name);
            Console.WriteLine("\nClass name is " + type.Namespace);

            Console.WriteLine("\nMethods is customerInfo class");

            MethodInfo[] methods = type.GetMethods();

            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }


            Console.WriteLine("\nProperties is customerInfo class");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }


            Console.WriteLine("\nConstructors  is customerInfo class");

            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
    }
}
