using System;

namespace P32.Lesson27_28
{
    
    //1. Generics:
    // ■ что такое generics;
    // ■ необходимость использования generics;
    // ■ создание generic классов;
    // ■ вложенные типы внутрь generic класса;
    // ■ использование ограничений;
    // ■ создание generic интерфейсов;
    public class Lesson27_28
    {

        public static void Main(string[] args)
        {
            Car<int> intCar = new Car<int>(1);
            Car<char> charCar = new Car<char>('1');
            Car<string> stringCar = new Car<string>("two");
            Car<Human> humanCar = new Car<Human>(new Human{FirstName = "Jack", LastName = "Smith", Age = 20});
            
            
            
            Console.WriteLine(intCar.GetPassenger());
            Console.WriteLine(stringCar.GetPassenger());
            Console.WriteLine(humanCar.GetPassenger());
            
            
            Human human = new Human{FirstName = "Stuart", LastName = "Stone", Age = 16};
            humanCar.Save(human);

            Car<Human>.Nested<string> nested = new Car<Human>.Nested<string>
            {
                CarValue = new Human(),
                NestedValue = "Hello nested"
            };
            
            nested.Show();

        }
        
        
        
    }
}