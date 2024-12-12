using System;

namespace P32.lesson7_8
{
    public class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string message) : base(message)
        {
            
        }
    }
}