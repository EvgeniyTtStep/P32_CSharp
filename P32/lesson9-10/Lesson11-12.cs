using System;

namespace P32.lesson9_10
{
    public class Lesson11_12
    {
        // public static void Main(string[] args)
        // {
        //     //індексатори 
        //     MyList myList = new MyList(15) {Count = 52 };
        //     myList[0] = 93;
        //     myList[1] = 66;
        //     Console.WriteLine(myList[0]);
        //     Console.WriteLine(myList.Count);
        //     Console.WriteLine(myList[1]);
        //     
        //     MyMatrix myMatrix = new MyMatrix{Arr = new []{10,20,30,40,50}};
        //     myMatrix[0, 0] = 1;
        //     myMatrix[0, 1] = 2;
        //     myMatrix[0, 2] = 3;
        //
        //     myMatrix.Arr[0] = 11;
        //     foreach (var arr in myMatrix.Arr)
        //     {
        //         Console.WriteLine(arr);
        //     }
        //
        // }
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


    class MyMatrix
    {
        
        public int [] Arr { get; set; }
        
        private int[,] Matrixxx = new int[10, 10];

        public int this[int row, int col]
        {
            get { return Matrixxx[row, col]; }
            set { Matrixxx[row, col] = value; }
        }
        
    }
}