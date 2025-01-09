using System;

namespace P32.lesson11_12
{
    public class Lessosn11_12_inharitance
    {
        // public static void Main(string[] args)
        // {
        //     Shape rectangle = new ColorRectangle();
        //     rectangle.Draw();
        //     // rectangle.RectangleDraw();
        //     // rectangle.ColorDrawing();
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
        public virtual void Draw()
        {
            Console.WriteLine("Shape //====================================");
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
        
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Rectangle //====================================");
        }
        
        public void RectangleDraw()
        {
            Console.WriteLine("Rectangle draw" + x + y);
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
        
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("ColorRectangle //====================================");
        }

        public void ColorDrawing()
        {
            Console.WriteLine("ColorRectangle draw" + color);
        }
    }
}