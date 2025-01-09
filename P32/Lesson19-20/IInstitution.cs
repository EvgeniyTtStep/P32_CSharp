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

        void Show();
    }

    interface IEnergySystem 
    {
        string Type { get; set; }
        
        void Show();
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


        void IInstitution.Show()=> Console.WriteLine("IInstitution Show");    
        
        void IEnergySystem.Show() => Console.WriteLine("EnergySystem Show");
        
        
        

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
        /*public static void Main(string[] args)
        {
            School school = new School {Name = 101, Description = "Good school"};
            school[0] = "A+";
            
            IInstitution school2 = new School {Name = 102, Description = "Good school"};
            school2.ToStudy();
            
            
            ((IInstitution)school).Show();
            ((IEnergySystem)school).Show();
        
            Console.WriteLine("==========================");
            
            IInstitution school3 = new School {Name = 103, Description = "Good school"};
            school3.Show();
            
            IEnergySystem school4 = new School {Name = 104, Description = "Good school"};
            school4.Show();
            
            Test test = new Test();
            Test test1 = new Test();
            Test test3 = (Test)test.Clone();
            
         
        }        */
    }

    class Test : ICloneable
    {

        public object Clone()
        {
            return this;
        }
    }
}