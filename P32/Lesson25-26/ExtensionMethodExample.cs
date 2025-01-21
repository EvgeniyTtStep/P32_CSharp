using System;

namespace P32.Lesson25_26
{
    public static class ExtensionMethodExample
    {
        
        public static void NewLevel(this PlayGame playGame, string msg)
        {
            Console.WriteLine("New level game = " + msg);
        }
    }
}