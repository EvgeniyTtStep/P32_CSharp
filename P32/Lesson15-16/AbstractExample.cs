using System;

namespace P32.Lesson15_16
{
    public class AbstractExample
    {
        public static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.Eat();
            
        }
        
    }


    abstract class Animal
     {
         public abstract void Eat();
         public abstract void Walk();
         public abstract void Sleep();

         

     }


    class Cat:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }

    class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public override void Walk()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
    
}