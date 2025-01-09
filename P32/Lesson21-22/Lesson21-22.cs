using System;

namespace P32.Lesson21_22
{
    public class Lesson21_22
    {
        public static void Main(string[] args)
        {
            Point point = new Point();
            point.Show();

            Day today = Day.THURSDAY;
            Console.WriteLine(today);

            if (today == Day.THURSDAY)
            {
                Console.WriteLine("Cьогодні четвер");
                Console.WriteLine(Enum.GetName(typeof(Day), today));
                Console.WriteLine((byte)Day.THURSDAY);
            }

            foreach (var day in Enum.GetNames(typeof(Day)))
            {
                Console.WriteLine("Day = " + day);
            }

            if (Enum.IsDefined(typeof(Day), "THURSDAY"))
            {
                Console.WriteLine("IsDefined");
            }


            // === Nullable ===

            int? num = null;

            Console.WriteLine(num?.GetType());

            if (num.HasValue)
            {
                Console.WriteLine(num.Value);
            }
            else
            {
                Console.WriteLine("No Value");
            }

            int res = num ?? 75;
            Console.WriteLine("Res = " + res);
        }
    }
}