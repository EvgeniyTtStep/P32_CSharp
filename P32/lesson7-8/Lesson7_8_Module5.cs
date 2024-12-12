using System;

namespace P32.lesson7_8
{

    class MyClass
    {
        public int X {get; set;}
        public int Y{ get;set;}

        public MyClass(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static MyClass operator +(MyClass myClass1, MyClass myClass2)
        {
            return new MyClass(myClass1.X + myClass2.X, myClass1.Y + myClass2.Y);
        }
        
        public static MyClass operator -(MyClass myClass)
        {
            return new MyClass(-myClass.X , -myClass.Y);
        }

        // public static bool operator ==(MyClass myClass1, MyClass myClass2)
        // {
        //    return myClass1.X == myClass2.X && myClass1.Y == myClass2.Y;
        // }
        
    }
    
    
    public class Lesson7_8_Module5
    {
        public static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass(10, 20);
            MyClass myClass2 = new MyClass(3, 7);
            //MyClass myClass3 = new MyClass(0, 0);
            
            // myClass3.X = myClass1.X + myClass2.X;
            // myClass3.Y = myClass1.Y + myClass2.Y;
            
            MyClass myClass3 = myClass1 + myClass2;
            
            Console.WriteLine(myClass3.X);
            Console.WriteLine(myClass3.Y);

            myClass3 = -myClass3;

            
            Console.WriteLine(myClass3.X);
            Console.WriteLine(myClass3.Y);
            
            Console.WriteLine(myClass1 == myClass2);

        }
        
    }
    
    
    
    
}