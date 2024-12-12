using System;
using System.Xml;
using P32.lesson3_4;

namespace P32.lesson3_4
{
    public partial class Student
    {
        private int id; // 0
        public string name; // ""
        protected string grade;
        internal string password;
        
        static public int count = 0;

        public Student()
        {
            Console.WriteLine("Main constructor");
            count++;
        }

        public Student(int id, string name, string grade, string password):this()
        {
            this.id = id;
            this.name = name;
            this.grade = grade;
            this.password = password;
        }

        //Alt+insert 
        public Student(string name, string grade): this(0, name, grade, "")
        {
            this.name = name;
            this.grade = grade;
        }

        static Student()
        {
         Console.WriteLine("Start static constructor: ");   
        }


        // public void setId(int id) => this.id = id;

        public void show()
        {
            Console.WriteLine("Student ID: " + id);
            Console.WriteLine("Student Name: " + name);
        }

        // REF
        public string show(ref int number) => "Student Number: " + number++;

        // OUT
        public int sum(out int num1, out int num2)
        {
            num1 = 10;
            num2 = 15;
            return num1 + num2;
        }

        //public void setPassword(string password) => this.password = password;
        public string getPassword() => this.password;

        public double Square { get; set; }

        public double Rectangle() => Square * (Square + 10);
        
        public double Radius { get; set; }
        
        public double Talia() => 2 * Math.PI * Radius;

        public double getGrade() => Math.Pow(9, 3);



        // public (int Min, int Max) GetMinMax(int[] array)
        // {
        //     return (array[0], array[1]);
        // }
        
    }
}


class MainClass
{
    // public static void Main(string[] args)
    // {
    //     Student student = new Student();
    //     student.show();
    //     Console.WriteLine();
    //     
    //     Student student2 = new Student{Square = 5};
    //     Console.WriteLine(student2.Rectangle());
    //     
    //     Student student3 = new Student{Radius = 10, Square = 10};
    //     Console.WriteLine("Talia = " + student3.Talia());
    //     Console.WriteLine("Grade = " + student3.getGrade());
    //
    //     int num = 10;
    //     student2.show(ref num); // ===== REF ====
    //     Console.WriteLine("num = "+num);
    //
    //     int num1 = 33;
    //     int num2 = 52;
    //     student2.sum(out num1, out num2); // ==== OUT ====
    //     Console.WriteLine("num1 = "+num1);
    //     Console.WriteLine("num2 = "+num2);
    //     
    //     int[] array = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    //      
    //     // === кортежі ====
    //     //student2.GetMinMax(array);
    // }
}