using System;
class Matrix
{
public static void Main()
{

int n=int.Parse(Console.ReadLine());
int k=n;

for(int i=1;i<=n;i++)
{

for(int j=i;j<=k;j++)
{

Console.Write(j+" ");

}
k=k+1;
Console.WriteLine();

}

}

}