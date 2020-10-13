using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    class CustomerInfo
    {

      public int id
        {
            get;
            set;
        }


        public string name
        {
            get;
            set;
        }
        
        public CustomerInfo(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public CustomerInfo()
        {
            this.id = -1;
            this.name = string.Empty;
        }


        public void printId()
        {
            Console.WriteLine("Id is " + this.id);
        }

        public void printName()
        {
            Console.WriteLine("Name is :" + this.name);
        }
    }
}
