using System;

namespace P32.Lesson19_20
{

    public interface ICamp: IInstitution
    {
        string Name { get; set; }
        int Price { get; set; }
    }
    
    public interface IInstitution
    {
        string this[int index] { get; set; }
        
        int Name{get;set;}
        string Description{get;set;}
       

        void ToStudy();
        
        int AvgMark();
    }

    interface IEnergySystem 
    {
        string Type { get; set; }
        
    }

    
    
    
    class School: IInstitution, IEnergySystem
    {
        private string[] marks = new string[5];
        private string _name;
        
        public string Type { get; set; }

        public string this[int index]
        {
            get => marks[index];
            set => marks[index] = value;
        }

        // string ICamp.Name
        // {
        //     get => _name;
        //     set => _name = value;
        // }

        public int Price { get; set; }

        public int Name { get; set; }
        public string Description { get; set; }
        
        public void ToStudy()
        {
           Console.WriteLine("Students in school " + Name + " are studying now");
        }

        public int AvgMark()
        {
            throw new System.NotImplementedException();
        }

        public void CoffeeBrake()
        {
            Console.WriteLine("Студенти школи " + Name + " відпочивають на перерві");
        }

    }


    class Run
    {
        public static void Main(string[] args)
        {
            School school = new School {Name = 101, Description = "Good school"};
            school[0] = "A+";
            
            IInstitution school2 = new School {Name = 102, Description = "Good school"};
            school2.ToStudy();
            
        }        
    }
}