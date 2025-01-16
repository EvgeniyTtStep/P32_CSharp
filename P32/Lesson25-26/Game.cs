using System;

namespace P32.Lesson25_26
{
    
    
    public delegate void Win(string msg);
    
    public class Game
    {
        public event Win WinEvent;

        public void StartWinEvent(string msg)
        {
            WinEvent?.Invoke(msg);
        }
        
    }

    public class PlayGame
    {
        public static void StartGame(string msg)
        {
            Console.WriteLine("Start game = "+ msg);
        }
        
        public static void EndGame(string msg)
        {
            Console.WriteLine("End game = " + msg);
        }
    }
}