using System;
using System.Collections.Generic;
using P32.Lesson29_30;

namespace P32.Lesson31_32
{
    public class Lesson31_32
    {
  

        /*public static void Main(string[] args)
        {
            Console.WriteLine("====== collections =======");
            Console.WriteLine("====== list =======");
            List<int> list = new List<int>(){1,2,3,4};
            list.Add(10);
            list.Add(24);
            list.Add(15);
            list.Add(33);
            list.Remove(33);
            list.RemoveAt(0);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine();

            Console.WriteLine("====== dic =======");

            Dictionary<string, int> dictionary = new Dictionary<string, int>(){{"Jack", 777}, {"Bob", 888}, {"Sam", 999}};
            dictionary.Add("One", 1);
            //dictionary.Add("Bob", 5);

            dictionary["Kevin"] = 8844;

            foreach (var item in dictionary)
            {
                Console.Write($"Key: {item.Key} Value:{item.Value}\n");
            }
            
            
            Console.WriteLine("====== stack =======");

            //LIFO
            Stack<string> stack = new Stack<string>();
            stack.Push("Jack");
            stack.Push("Bob");
            stack.Push("Sam");
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek()); 

            
            Console.WriteLine("====== queue =======");

            //FIFO 
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");
            queue.Enqueue("Five");
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            
            
            
            // List<Emplie> emplies = new List<Emplie>();
            // emplies.Add(new Emplie() { name = "Jack", email = "jack@gmail.com" });
            // emplies.Add(new Emplie() { name = "Bob", email = "bob@gmail.com" });

            
            
            Console.WriteLine("====== Sorted List =======");
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                { 2, "Jack" },
                { 4, "Bob" },
                { 1, "Sam" }
            };
            sortedList.Add(3, "Kevin");
            //sortedList.Add(3, "Stuart");

            foreach (var item in sortedList)
            {
                Console.Write($"{item.Key}  {item.Value}\n");
            }
            
            
            Console.WriteLine("====== Collect Interfaces =======");

            IList<int> intts = new List<int>();
            intts.Add(1);
            intts.RemoveAt(0);
            
            ICollection<int> icollection = new List<int>();

            IDictionary<int, int> dictionary1 = new Dictionary<int, int>();
            dictionary1.Add(1,1);
            dictionary1.Add(2,2);
            dictionary1.Add(3,3);
            dictionary1.Add(4,4);
            
            
            
            Console.WriteLine("============ Records ==============");

            /*
            P32Record record1 = new P32Record("Bob", 2000);
            P32Record record2 = new P32Record("Bob", 2000);
            
            Console.WriteLine("Record = " + (record1.Equals(record2)));
            Console.WriteLine(record1);
            Console.WriteLine(record2);
            //record1.Name = "Jack";
            

            Teacher teacher1 = new Teacher("John", 1); 
            Teacher teacher2 = new Teacher("John", 1);
            //teacher1.FirstName = "John";
            
            
            Console.WriteLine("Class = "+ (teacher1.Equals(teacher2)));
            Console.WriteLine(teacher1);
            Console.WriteLine(teacher2);
            
            Console.WriteLine("Title = " + record1.Title);
            
            record1.Show();
            


        }
    
    */
    }
}