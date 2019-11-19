using System;
class Fibonacci
{

public static void Main()
{

int n=int.Parse(Console.ReadLine());

int i=0;
int j=1;

Console.Write(i+" "+j);
for(int k=3;k<n;k++)
{
int sum=i+j;
Console.Write(" "+sum);
i=j;
j=sum;


}//for

}//main


}//class