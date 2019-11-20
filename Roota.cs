using System;

class Roota
{
public static void Main()
{

int n=int.Parse(Console.ReadLine());

int x=int.Parse(Console.ReadLine());
double result=1;

for(int i=1;i<=x;i++)
{
result=result*n;
}
Console.WriteLine("_________"+result);

}


}