using System;

class MaxPlatform2x2 { 
    public static void Main()
       { 
             // Declare and initialize the matrix
                int[,] matrix = {    { 0, 2, 4, 0, 9, 5 },    { 7, 1, 3, 3, 2, 1 },    { 1, 3, 9, 8, 5, 6 },    { 4, 6, 7, 9, 1, 0 }   };

Console.WriteLine("row size:"+matrix.GetLength(0));
Console.WriteLine("column size:"+matrix.GetLength(1));



for(int i=0;i<matrix.GetLength(0);i++)
{

    for(int j=0;j<matrix.GetLength(1);j++)
    {

        Console.Write(" "+matrix[i,j]);
    }
    Console.WriteLine();

}




                }

       }