using System;

class SeqArrayCount
{
public static void Main()
{

Console.Write ("Enter array length: ");
			int length = Int32.Parse (Console.ReadLine ());
			int[] arr = new int[length];

			for (int i = 0; i < arr.Length; i++) 
			{
				arr [i] = Int32.Parse (Console.ReadLine ());
			}
            int [] final=new int[length];
            int temp=0;
            int count=0;

Console.WriteLine("enter ur no to find how many elements present");
int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++) 
			{
                if(arr[i]==n)
                 {
                     
                     final[i]=arr[i];
                     count++;
                 }
                 
            }
Console.WriteLine("repeated no are :"+count);
            for(int i=0;i<count;i++)
            {
               Console.WriteLine("elements are:"+final[i]); 
                
            }



}


}

