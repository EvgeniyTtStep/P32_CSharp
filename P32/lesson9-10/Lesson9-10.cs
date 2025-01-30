using System;
using System.IO;
using P32.lesson7_8;

namespace P32.lesson9_10   
{
    public class Lesson9_10
    {
        
        public static void check()
        {
            throw new FileNotFoundException();
            
        }

        public static void my_exception(int number) 
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
                throw new MyException("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
                throw new MyException("The number is odd");
            }
            
        }
        
        /*public static void Main(string[] args)
        {
            //Console.WriteLine(10/0);
            String name = null;
        
            int a = 10;
            int b = 0;
        
            try
            {
                //Console.Write(a / b);
                Console.Write(name.Length);
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine("Division by zero = " + exception.Message);
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("Null reference = " + exception.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to continue...");
            }
            
            Console.WriteLine("\n\nEnd program");
            
            
           // my_exception(10);
            
            check();
            
        
        }*/
    }
}