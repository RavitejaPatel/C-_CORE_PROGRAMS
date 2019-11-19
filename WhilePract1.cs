using System;

class whilePract
{

    public static void Main()
    {

int n=int.Parse(Console.ReadLine());

Console.Write("sum is 1");

int i=1;
int sum=0;
while(i<n)
{

sum=sum+i;
i++;
Console.Write("+"+i);

}
Console.Write("="+sum);


    }
    
}