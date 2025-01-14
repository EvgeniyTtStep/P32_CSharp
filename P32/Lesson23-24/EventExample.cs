using System;

namespace P32.Lesson23_24
{
    
    public delegate void Notify(string msg);
    
    public class EventExample
    {
        public event Notify NotifyEvent; //створення події 

        //цей метод буде запускати подію
        public  void NotifyMethod(string msg)
        {
            NotifyEvent?.Invoke(msg);//виклик події
        }
    }

    class EmailSender
    {
        
        //цей метод буде слухати подію 
       public static void SendEmail(string msg)
        {
            Console.WriteLine("Event send message: " + msg);
        }

        public static void SetStatus(string msg)
        {
            Console.WriteLine("Event set status: " + msg);
        }
    }
}