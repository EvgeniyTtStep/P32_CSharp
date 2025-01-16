using System;

namespace P32.Lesson23_24
{
    
    public delegate void MyDelegate(string str);
    
    public class MyProgram
    {

       public static void Show1(string str)
        {
            Console.WriteLine("Show 1 " + str);
        }
       
        public static void Show2(string str)
        {
            Console.WriteLine("Show 2 " + str);
        }
        
        public static void Show3(string str)
        {
            Console.WriteLine("Show 3 " + str);
        }
        
        public static void Show4(string str)
        {
            Console.WriteLine("Show 4 " + str);
        }
       
        
    }

    class Run
    {
        /*public static void Main(string[] args)
        {
            Console.WriteLine("==== Delegate ====");
            MyDelegate del = MyProgram.Show1;
            del += MyProgram.Show2;
            del += MyProgram.Show3;
            del += MyProgram.Show4;
            
            del("Hello Delegate!");
            
            
            Delegate combine = Delegate.Combine(del, del);
            Delegate removeDel = Delegate.Remove(combine, del);
            
            Delegate multik = MulticastDelegate.Combine(removeDel, del);
            
            Console.WriteLine("==== Event ====");
            
            EventExample eventExample = new EventExample();
            eventExample.NotifyEvent += EmailSender.SendEmail;
            eventExample.NotifyEvent += EmailSender.SetStatus;
            
            eventExample.NotifyMethod("Hello Event!");
            
        }*/
    }
}