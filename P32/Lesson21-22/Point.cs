using System;

namespace P32.Lesson21_22
{
    public struct Point
    {
         int X; //0
         int Y; //0

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Show()
        {
            Console.WriteLine("x: {0}, y: {1}", X, Y);
        }

        
    }
}