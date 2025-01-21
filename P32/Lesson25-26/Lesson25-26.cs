using System;
using System.Linq;
using P32.Lesson25_26;

namespace P32.Lesson25_16
{
    public class Lesson25_26
    {
        public static void Main(string[] args)
        {
            
            Game game = new Game();
            game.WinEvent += PlayGame.StartGame;
            game.WinEvent += PlayGame.EndGame;
            
            game.StartWinEvent("You win this game");
            
            PlayGame playGame = new PlayGame();
            playGame.NewLevel("You win this game");
            
            
             

            Console.WriteLine("===== Aнонімний метод =====");

            MyDelegate myDelegate = delegate(string msg)
            {
                Console.WriteLine(msg);
            };
            
            Console.WriteLine("===== Lambda =====");

            Calculator calculator = (x, y, z) => x + y / z ;
            Console.WriteLine(calculator(7, 9, 2));
            
            Func<int, int> square = (x) => x * x;
            Console.WriteLine(square(7));
            
            
            
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            var tenNumbers = numbers.Select((x) => x * 10);
            foreach (var num in tenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            
            numbers
                .Where((x) => x % 2 == 0)
                .ToList()
                .ForEach(Console.Write);
            
            
            
        }
    }
}