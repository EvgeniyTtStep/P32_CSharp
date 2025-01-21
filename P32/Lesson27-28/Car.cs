using System;

namespace P32.Lesson27_28
{
    public class Car<T>
    {
        private T passenger;


        public class Nested<U>
        {
            public T CarValue { get; set; }
            public U NestedValue { get; set; }

            public void Show()
            {
                Console.WriteLine($" {this.CarValue.ToString()}, {this.NestedValue.ToString()}");
            }
        }


        public Car(T passenger)
        {
            this.passenger = passenger;
        }


        public T GetPassenger()
        {
            return passenger;
        }

        public T GetPassenger(T passenger)
        {
            return passenger;
        }

        public void Save(T passenger)
        {
            Console.WriteLine($"Save {passenger}");
        }
    }
}