using System;

class MaxPlatform2
 {
       static void Main()
         {
                // Declare and initialize the matrix   
                int[,] matrix = {    { 0, 2, 4 },    { 7, 1, 3 },    { 1, 3, 9 },    { 4, 6, 7 }   }; 
 
  // Find the maximal sum platform of size 2 x 2  
   long bestSum = long.MinValue;
   Console.WriteLine("--------------------------------------------------------------ccccc"+bestSum);
      int bestRow = 0;
         int bestCol = 0; 
 
  for (int row = 0; row < matrix.GetLength(0) - 1; row++)
     {
             for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                 {  
    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
         if (sum > bestSum)
              {
                        bestSum = sum;
                              bestRow = row;  
                                  bestCol = col; 
                                      }
                                          }
                                             } 
 
  // Print the result  
   Console.WriteLine("The best platform is:");
      Console.WriteLine("  {0} {1}",    matrix[bestRow, bestCol],    matrix[bestRow, bestCol + 1]); 
        Console.WriteLine("  {0} {1}",
            matrix[bestRow + 1, bestCol],    matrix[bestRow + 1, bestCol + 1]);
               Console.WriteLine("The maximal sum is: {0}", bestSum); 
                } 
                }