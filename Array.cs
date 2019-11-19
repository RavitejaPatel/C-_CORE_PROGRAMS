using System;
class Arr
{

public static void Main()
{

int final=int.Parse(Console.ReadLine());

  
Console.WriteLine("enter size of array:");
int n=int.Parse(Console.ReadLine());

int[] arr=new int[n];

Console.WriteLine("enter array:");
int sum=0;

for(int i=0;i<n;i++)
{

    arr[i]=int.Parse(Console.ReadLine());
}


for(int i=0;i<arr.Length;i++)
{
int temp=arr[i];
Console.WriteLine("======"+temp);
for(int j=i+1;j<arr.Length;j++)
{
  Console.WriteLine("two");

sum=temp+arr[j];
Console.WriteLine("three"+sum);
if(sum == 9)
{
    Console.WriteLine("test");

Console.WriteLine(arr[i].ToString(),arr[j].ToString());

}//if


}

}//outer for







}//main


}