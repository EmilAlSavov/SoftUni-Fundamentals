using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };
            int index2 = 0;
            int counter = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (counter == ((array.GetLength(0) * array.GetLength(1)) - 1))
                {
                    break;
                }
                Console.Write(array[index2, i] + " ");
                if (i == array.GetLength(1) - 1)
                {
                    index2++;
                    i = 0;
                }
                
                counter++;
            }
        }
        static void ExchangeArrayUncle(ref int[] array, int splitIndex)
        {
            int[] array1 = new int[array.Length];
            if (splitIndex >= array.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            if (splitIndex == array.Length - 1)
                return; // no exchange required - return the same array

            int j = splitIndex + 1;
            for (int i = 0; i < array.Length; i++)
            {
                array1[i] = array[j];
                // next line is the trick - debug it to see what happens with j when reaches end of array!
                j = (j + 1) % array.Length; //increase j but if goes over array size - reset to 0!!!!

            }
            array = array1;
        }
    }
}
