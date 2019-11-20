using System;
class Series
{

public static void Main()
{

int n=int.Parse(Console.ReadLine());
int x=int.Parse(Console.ReadLine());
int temp=1;
int denom=1;
int final=1;
for(int i=1;i<=n;i++)
{
//Console.WriteLine(i);
int fact=i;


denom=denom*x;


//int denom = x*fact;
//int denom=(int)Math.Pow(x,fact);

fact*=temp;
Console.WriteLine("++"+fact);
Console.WriteLine("__"+denom);
temp=fact;

final=fact/denom;
Console.WriteLine("******"+final);

}
Console.WriteLine("dddddddddd"+" "+(1/2));

}
}