using System;

 
 
class Factorial { 
     public static void Main() 
      {  
 

for (int small=1, large=10; small<large; small++, large--) 
{
    Console.WriteLine(small + " " + large);
     }

     Console.WriteLine("------------------------------------");

int n = int.Parse(Console.ReadLine()); 
int sum = 0; 
for (int i = 1; i <= n; i += 2) 
{
    if (i % 7 == 0)  
    {
      Console.WriteLine("+++"+i);
         continue;
           }  
           sum += i; 
           }
            Console.WriteLine("sum = " + sum); 





      }
}