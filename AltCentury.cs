using System;

class CenturyAlt{

public static void Main()
{

Console.WriteLine("enter range");
int count=int.Parse(Console.ReadLine());






for(int i=2;i<=count+2;i++)
{

if(i%2==0)
Console.WriteLine(i);
else

    Console.WriteLine("-{0}",i);


/*
if(i%2==0)
Console.WriteLine(i);
else
Console.WriteLine(i+2*(-i));
*/


}//for
    


}


}