using System;

namespace MultiDimensionalArrays.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare 2-D array
            string[,] matrix;

            // declare 3-D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]);
        }
    }
}
