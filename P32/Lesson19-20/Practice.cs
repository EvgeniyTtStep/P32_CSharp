using System;

namespace P32.Lesson19_20
{
    public class Practice
    {
        
    }
    
    public interface IOutput{
        void Show();
        void Show(string info);
    }
    
    public interface ISort{
        void SortAsc(); 
        void SortDesc(); 
        void SortByParam(bool isAsc);
    }
    
    class Array:IOutput, ISort{
        public void Show(){
            Console.WriteLine("1 2 3 4 5");
        }
        public void Show(string info){
            Console.WriteLine("1 2 3 4 5 " + info);
        }
        public void SortAsc(){
            Console.WriteLine("1 2 3 4 5");	
        }
        public void SortDesc(){
            Console.WriteLine("5 4 3 2 1");	
        }
        
        public void SortByParam(bool isAsc){
            Console.WriteLine("2 4 5 1 3");
            if(isAsc == true){
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
    class Run111
    {
        public static void Main(string[] args)
        {
            ISort no = new Array();
         
            no.SortByParam(true);
            no.SortByParam(false);
            
            
        }        
    }
}