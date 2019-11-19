using System;

 
 
class Num3nd7 { 
     public static void Main() 
      {  

int num=int.Parse(Console.ReadLine());

for(int i=1;i<=num;i++)
{

if( i%(3*7) == 0)

continue;

Console.Write(i+" ");

}



      }

}
 