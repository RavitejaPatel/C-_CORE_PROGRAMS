
using System;

class IncDec
{

static public void Main()
{
    int a = 5; 
    int b = ++a; 

    int d=5;
    int e=6;
    int result= (++a)+(++b)+(a--);
 
Console.WriteLine(a); // 6
 Console.WriteLine(b); // 6
 Console.WriteLine(result);
 Console.WriteLine("=====================================");

 int p=5;
 int q=6;
 int r=++p;
 Console.WriteLine(r);
 Console.WriteLine(p);

 p=q++;
  Console.WriteLine(p);
 Console.WriteLine(q);

 Console.WriteLine(p+q+r);

 
} 
}