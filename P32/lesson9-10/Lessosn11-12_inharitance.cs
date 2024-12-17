using System;
using System.Globalization;

namespace P32.lesson9_10
{
    public class Lessosn11_12_inharitance
    {
        // public static void Main(string[] args)
        // {
        //     Shape rectangle = new ColorRectangle();
        //     rectangle.Draw();
        //     
        //     
        // }
    }

    class Shape
    {
        protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Shape");
        }
    }

    class Rectangle:Shape
    {
        protected int y;

        public int Y
        {
            get { return y; }
            set
            {
                if (x < 0)
                {
                    y = value * -1;
                }

                y = value;
            }
        }
        
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
        
    }

    class ColorRectangle : Rectangle 
    {
        string color;

        public string Color
        {
            get { return color; }
            set
            {
                if (x == 0)
                {
                    color = value;
                }
                color = value;
            }
        }
        
        public void Draw()
        {
            Console.WriteLine("ColorRectangle");
        }
    }
}