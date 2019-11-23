using System;
class ArrayIndexMul
{


public static void Main()
{
Console.WriteLine("enter array size");
int size=int.Parse(Console.ReadLine());
int[] arr=new int[size];

for(int i=0;i<arr.Length;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}

for(int i=0;i<arr.Length;i++)
{
Console.Write(" "+(i*5));
}



}


}