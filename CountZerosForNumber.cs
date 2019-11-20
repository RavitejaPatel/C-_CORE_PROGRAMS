using System;

class Pract
{



static void Main(string[] args)
{    int count=0;
   
   int n=3628800;
   int res=0;

   do{

       if(n%10 == 0)
          {
           count++;
           Console.WriteLine("-------"+count);
          }
          
      res=n;
      n=res/10;    
   }
   while(n%10 == 0);
   

   Console.WriteLine("no of zeros"+count);
   }
}