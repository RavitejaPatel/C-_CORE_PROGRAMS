
using System;

class SymentricMat
{

    public static bool isSymantic=true;
static void Main()
{


    Console.Write("Enter MATRIX elements: ");
    int n = int.Parse(Console.ReadLine());

int[] arr=new int[n];
Console.WriteLine("enter array elements");
for(int i=0;i<n;i++)
{
arr[i]=int.Parse(Console.ReadLine());
}



if(isSymantic)
{
for(int i=0;i<n;i++)
{
   
    if(arr[i] != arr[n-i-1])
    {
     isSymantic=false;
    }

}//for

}//if

if(isSymantic == true)
{
    Console.WriteLine("array is symantic");
}


}
}

