using System;

class ZeroCount
{
public static void Main()
{


int n=int.Parse(Console.ReadLine());
long temp=1;
long fact=0;
for(int i=1;i<=n;i++)
{
//Console.WriteLine(i);
fact=i;
fact*=temp;
temp=fact;
}
Console.WriteLine("++"+fact);



long res=0;
int count=0;

   do{

       if(fact%10 == 0)
          {
           count++;
           Console.WriteLine("-------"+count);
          }
          
      res=fact;
      fact=res/10;    
   }//do
   while(fact%10 == 0);
   
Console.WriteLine("no of zers:"+count);

}
}