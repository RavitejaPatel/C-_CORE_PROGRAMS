using System;

class A{
public static void Main(String[] args)
{
int[] arr=new int[3];
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine("enter array vallues:");
    arr[i]=int.Parse(Console.ReadLine());
}
for(int i=0;i<arr.Length;i++)
{
    Console.WriteLine("array values are:"+arr[i]);
}


Console.WriteLine(arr.Length);
}

}