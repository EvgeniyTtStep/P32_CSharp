using System;

namespace P32.lesson5_6
{

    partial class Teacher
    {
        public string Email { get; set; }

        public void ShowEmail()
        {
            Console.WriteLine(Email);
        }
    }
    
    
    public class Lesson5_6
    {
        public static void Sum(int[] array)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }
        }

        public static void Sum(int a, params int[] array)
        {
            int sum = 0;
            foreach (int elem in array)
            {
                sum += elem;
            }

            Console.WriteLine(sum);
        }

        // public static void Main(string[] args)
        // {
        //     int[] array = { 1, 2, 4, 5, 6, 7 };
        //     Sum(1, 2, 3, 4, 5, 6, 7);
        //     Sum(1,array);
        //     
        //     Teacher teacher = new Teacher{
        //         FirstName = "Jack",
        //         LastName = "Lukas",
        //         Email = "jack@gmail.com"};
        //     teacher.ShowEmail();
        //     teacher.ShowInfo();
        //     
        // }
    }
}