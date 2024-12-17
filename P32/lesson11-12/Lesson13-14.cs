using System;

namespace P32.lesson11_12
{
    public class Lesson13_14
    {
        public static void Main(string[] args)
        {
            C c = new C("Name c");
        }
    }


    class A
    {
        private string name;
        
        public A()
        {
            name = "A";
            Console.WriteLine("A");
        }

        public A(string name)
        {
            this.name = name;
            Console.WriteLine("A " + this.name);
        }
    }


    class B:A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public B(string name) : base(name)
        {
            Console.WriteLine("B " + name);
        }
        
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine("C");
        }

        public C(string name) : base(name)
        {
            Console.WriteLine("C " + name);
        }
        
    }
}