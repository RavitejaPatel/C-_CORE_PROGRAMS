using System;
class MulDimMat
{

public static void Main()
{

Console.WriteLine("enter row and columns length");
int row=int.Parse(Console.ReadLine());
int col=int.Parse(Console.ReadLine());

int[,] array=new int[row,col];

for(int i=0;i<row;i++)
{

for(int j=0;j<col;j++)
{

Console.Write("array[{0},{1}] = ",i,j);
                 array[i,j] = int.Parse(Console.ReadLine()); 


}//for

}//for




for(int i=0;i<row;i++)
{

for(int j=0;j<col;j++)
{
      Console.Write(" " + array[i,j]); 
}

  Console.WriteLine();
}




}


}