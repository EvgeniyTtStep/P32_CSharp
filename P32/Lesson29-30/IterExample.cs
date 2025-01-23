using System.Collections.Generic;

namespace P32.Lesson29_30
{
    public class IterExample
    {
        public static IEnumerable<int> GetExample(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                yield return i;
            }
        }
    }
}