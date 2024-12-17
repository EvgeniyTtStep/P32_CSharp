using System;

namespace P32.lesson9_10
{
    public class Lesson11_12_properties
    {
        // public static void Main(string[] args)
        // {
        //     Human human = new Human();
        //     human.Name = "James"; //set
        //     Console.WriteLine(human.Name); //get
        //
        //     human.Salary = 1000;
        //     
        //     Console.WriteLine("Salary = " + human.Salary);
        // }
    }


    class Human
    {
        private string name; //properties

        private int Age { get; set; } = 16;

        private decimal salary;
        
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }


        public string Name
        {
            get => name; 
            set => name = value; 
        }

        private void show()
        {
            Console.WriteLine("Name: {0}", name);
        }
    }
}