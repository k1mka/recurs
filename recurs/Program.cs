using System;

namespace recurs
{
    internal class Program
    {
        static void PrintArray(int[] myArray, int i = 0)
        {
            if (i >= myArray.Length)
                return;

            PrintArray(myArray, i + 1);

            Console.WriteLine(myArray[i]);


        }



        static void Main(string[] args)
        {
            int[] myArray = { 3, 4, 8 };

            PrintArray(myArray);
        }
    }
}
