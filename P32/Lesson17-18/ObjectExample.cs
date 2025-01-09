using System;
using System.Collections.Generic;

namespace P32.Lesson17_18
{
    public class ObjectExample
    {
        /*public static void Main(string[] args)
        {
            Phone phone = new Phone { Name = "Phone 11", Brand = "Apple" };
            Phone phone1 = new Phone { Name = "Phone 11", Brand = "Apple" };
            Console.WriteLine(phone);
            
            Console.WriteLine("Equals = " + phone.Equals(phone1));
            
            Console.WriteLine(phone.GetHashCode());
            Console.WriteLine(phone1.GetHashCode());
            Console.WriteLine("Phone 11".GetHashCode());
            Console.WriteLine("Phone 11".GetHashCode());
            Console.WriteLine("===================");
            Console.WriteLine("Phone 11".GetType());
            Console.WriteLine(12.GetType());
        
            Phone phone2 = phone1;
            
            //Boxing/Unboxing
            int num = 52;
            object obj = num;//boxing
            Console.WriteLine(obj + " " + obj.GetType());
            
            object obj2 = 88;//boxing
            int num2 = (int)obj2;//uboxing
            Console.WriteLine(num2 + " " + num2.GetType() +" "+ obj2.GetType());
        }*/
    }

    class Phone:Object
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nBrand: {Brand}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Phone)
            {
                return this.Name == (obj as Phone).Name;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Object.ReferenceEquals(Name, null) ? 0 : Name.GetHashCode() + Brand.GetHashCode();
        }
    }
}