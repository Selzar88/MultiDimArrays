using System;

namespace MultiDimArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            string[,] matrix;

            //declare 3D array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3}, //row 0
                {4,5,6}, //row 1
                {7,8,9}  //row 2
            };

           

            string[,,] array3D = new string[,,]
            {//depth
                {//height
                    {"000", "001" },//length
                    {"010", "011" },
                    {"Hi there", "What's up"}
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                {"one", "two" },
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";

            int dimension = array2DString.Rank;

            //int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}",dimension);

            //Console.WriteLine("Central value is {0}", array2DString[1,1]);
            Console.ReadKey();
        }
    }
}
