namespace P32.Lesson27_28
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Human()
        {
        }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        public static void Swap<T>(ref T first, ref T second)
        {
            T temp = first;
            first = second;
            second = temp;
            
        }
        
        

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAge: {Age}";
        }
    }
}