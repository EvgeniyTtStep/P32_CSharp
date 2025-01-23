using System;
using System.Collections.Generic;
using P32.Lesson27_28;

namespace P32.Lesson29_30
{
    public class Lesson29_30
    {
        public static void Main(string[] args)
        {
            
            Human human = new Human("Bill", "Debugs", 16);
            GenericDelegate<string> strDelegate = human.GetFullName;
            string res = strDelegate("****");
            Console.WriteLine(res);
            
            Console.WriteLine("====== iterator =======");
            IEnumerable<int> enumerable = IterExample.GetExample(10);

            foreach (var var in enumerable)
            {
                Console.WriteLine(var);
            }
            
            
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
        }
    }
}