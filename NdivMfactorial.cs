using System;

class NdivM_fact
{

public static void Main()
{

int n=int.Parse(Console.ReadLine());
int m=int.Parse(Console.ReadLine());

int o=n-m;

if(n>m)
{

for(int i=n-1;i>0;i--)
{

    n*=i;
    
}
Console.WriteLine(n);

for(int i=m-1;i>0;i--)
{

    m*=i;
    
}
Console.WriteLine(m);

n/=m;
Console.WriteLine("N!/M!=="+n);



for(int i=o-1;i>0;i--)
{
    o*=i;
}

int final=(n/=m)/o;




}//if



}
}