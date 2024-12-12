using System;

namespace P32.lesson9_10
{
    public class Lesson11_12
    {
        public static void Main(string[] args)
        {
            //індексатори 
            MyList myList = new MyList(15) {Count = 52 };
            myList[0] = 93;
            myList[1] = 66;
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList.Count);
            Console.WriteLine(myList[1]);

        }
    }
    class MyList
    {
        public int Count{ set; get; }
        private int[] arr = new int[10];


        public MyList(int count)
        {
            Count = count;
        }
        //дозволяє використовувати обєкти як масиви 
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
}