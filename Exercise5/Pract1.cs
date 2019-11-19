using System;
 
 //1. Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.

 class Prog{

public static void Main()
{

    int a=int.Parse(Console.ReadLine());
    int b=int.Parse(Console.ReadLine());
int temp=0;

if(a>b)
{
    temp=a;
    a=b;
    b=temp;
    Console.WriteLine(a+"and"+b);

}
else
{
    Console.WriteLine("{0} is smaller than {1}",a,b);
}


}

 }