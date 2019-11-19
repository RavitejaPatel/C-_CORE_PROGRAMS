using System;

class Nulble
{
    public static void Main()
    {
Nullable <int> a=null;
int? a1=20;
Console.WriteLine(a.GetValueOrDefault());
Console.WriteLine(a1);


Nullable<int> i1 = null; 
int? i2 = i1;
Console.WriteLine("----"+i1+i2+a1);


    }
}