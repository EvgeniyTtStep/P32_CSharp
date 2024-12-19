using System;

namespace P32.Lesson15_16
{
    public class Lesson15_16
    {
    //     public static void Main(string[] args)
    //     {
    //         Console.WriteLine("Enter an even number: ");
    //         int num =  int.Parse(Console.ReadLine());
    //
    //         if (num % 2 == 0)
    //         {
    //             Console.WriteLine(num);
    //         }
    //         else
    //         {
    //             try
    //             {
    //                 throw new MyException("This is not an even number", num);
    //             }
    //             catch (MyException e)
    //             {
    //                 Console.WriteLine($"Exception {e.Message}.\n Number = {e.InvalidNumber}");
    //             }
    //         }
    //
    //         Bread bread = new TostBread();
    //         bread.Bake();
    //
    //     }
    //     
    }

    class MyException: Exception
    {
        public int InvalidNumber { get;}
        
        public MyException(string message, int number) : base(message)
        {
            InvalidNumber = number;
        }
    }
}