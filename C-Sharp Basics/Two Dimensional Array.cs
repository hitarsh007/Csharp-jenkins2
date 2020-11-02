using System;
using System.Data;

namespace C_Sharp_Basics
{
    class Two_Dimensional_Array
    {
        static void Main()
        {
            //datatype[,] arrname=newdatatype[row, column]
            //int[,] matrix=new int[3,3]
            int[,] matrix = new int[2, 2] { { 10, 20 }, { 30, 40 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix[i, j]);

                }

            }
            Console.Read();


            Console.WriteLine("Enter Rows");
            int row = Convert.ToInt32(Console.ReadLine());
        }

    }
}
