using System;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    public class Kata
    {

        public static long rowSumOddNumbers(long n)
        {
            long[,] array = new long[n, n];
            long rezult = 0;
            array[0, 0] = 1;
            for (int i = 1; i < n; i++)
            {
                array[i, 0] = array[i - 1, 0] + i * 2;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    array[i, j] = array[i, j - 1] + (i + j+1) * 2;
                    rezult += (i + j) == n ? array[i, j] : 0;
                }
            }
            Print(array);
            return rezult;
        }
        public static void Print(long[,] printArray)
        {
            for (int i = 0; i < printArray.GetLength(0); i++)
            {
                for (int j = 0; j < printArray.GetLength(1); j++)
                {
                    Console.Write($"{printArray[i, j]}  ");

                }
                Console.WriteLine();
            }

        }

        public static void Main(string[] args)
        {

            Console.WriteLine(rowSumOddNumbers(1));

        }

    }
}
