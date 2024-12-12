using System;

namespace P32.lesson5_6
{
    public partial class Teacher
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }
}