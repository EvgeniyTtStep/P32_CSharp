using System;

namespace P32.lesson9_10
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