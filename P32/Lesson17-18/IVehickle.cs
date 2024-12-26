using System;

namespace P32.Lesson17_18
{
    public interface IVehickle
    {
        int Name { get; set; }
        int Vendor { get; set; }
        
         void Run();
    }

    public interface IFuel
    {
        void Burn();
    } 
        
        
        
        

    class Car:IVehickle, IFuel
    {
        public int Name { get; set; }
        public int Vendor { get; set; }

        public void Run()
        {
            Console.WriteLine("Car running...");
        }

        public void Burn()
        {
            Console.WriteLine("Gaz burning...");
        }
        
    }

    class A
    {
        
    }

    class B: A, IFuel, IVehickle
    {      public int Name { get; set; }
           public int Vendor { get; set; }
             
        public void Burn()
        {
            throw new NotImplementedException();
        }

  

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
    
}