namespace P32.lesson9_10
{
    public class Lessosn11_12_inharitance
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            
        }
    }

    class Shape
    {
       protected int x;
        public int X
        {
            get { return x; }
            set { x = value; }
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
    }
    
    
}