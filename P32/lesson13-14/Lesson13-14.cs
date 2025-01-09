using System;

namespace P32.lesson13_14
{
    public class Lesson13_14
    {
        // public static void Main(string[] args)
        // {
        //     // A c = new C("Name c");
        //     // c.Show();
        //     // c.Method();
        //     
        //     A a = new A();
        //     
        // }
    }


    class A
    {
        protected string name;
        
        public A():this("Default constructor")
        {
            Console.WriteLine(name);
        }

        public A(string name)
        {
            this.name = name;
            Console.WriteLine("A " + this.name);
        }

        public void Show()
        {
            Console.WriteLine("Show A ");
        }

        public virtual void Method()
        {
            Console.WriteLine("Method A ");
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

        public new void Show()
        {
            Console.WriteLine("Show B " + name);
        }

        public override void Method()
        {
            Console.WriteLine("Method B ");
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

        
        public new void Show()
        {
            Console.WriteLine("Show C ");
        }
        
        public override void Method()
        {
            Console.WriteLine("Method C ");
        }
        
    }
}