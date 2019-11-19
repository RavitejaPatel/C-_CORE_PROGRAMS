using System;
class Nulblll
{

public static void Main()
{
  /*
int i = 5;
 int? ni = i; 
 Console.WriteLine(ni); // 5 
 
i =(int)ni; // this will fail to compile 
Console.WriteLine("this is"+i); // True i = ni.Value; Console.WriteLine(i); // 5 
 
ni =null; 
Console.WriteLine(ni.HasValue); // False //i = ni.Value; // System.InvalidOperationException
 i = ni.GetValueOrDefault();
  Console.WriteLine(i); // 0

*/

  //clConsole.WriteLine(12 & (1 << 3));
/*
 Console.Write("Enter number: ");
            int v = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << 26;
            int bitAt24 = (v & mask) != 0 ? 1 : 0;
            Console.WriteLine(bitAt24);
Console.WriteLine(v | (1 << 3));

*/
DateTime d = new DateTime(2012, 02, 27, 17, 30, 22); 
Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
 Console.WriteLine("{0:d.MM.yy}", d); 

}
}