using System;

namespace P32.Lesson15_16
{
    public class SealedExample
    {
    
    }

    sealed class House
    {
        public int RoomNumber { get; set;}

        public House()
        {
        }

        public House(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public void showNumber()
        {
            Console.WriteLine("Number : {0}, Second number: {1}", RoomNumber, 10);
        }
    }

    // class MyHouse: House
    // {
    // }


    class Bread
    {
        public int BreadNumber { get; set; }

        public virtual void Bake()
        {
            Console.WriteLine("Bread is being baked...");
        }
    }

    class Borodinsky: Bread 
    {
        public sealed override void Bake()
        {
            Console.WriteLine("Borodinsky is being baked...");
        }
    }

    class TostBread:Borodinsky
    {
        // public override void Bake()
        // {
        //     Console.WriteLine("Ponchick is being baked...");
        // }
    }
}