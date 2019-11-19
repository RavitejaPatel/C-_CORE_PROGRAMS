using System;

class Lucky
{
public static void Main()
{

for(int i=1;i<=9;i++)
{
    for(int j=0;j<=9;j++)
    {
        for(int k=0;k<=9;k++)
        {
            for(int l=0;l<=9;l++)
            {

                if(i+j==k+l)
                {
                    Console.WriteLine(       " " + i + " " + j + " " + k + " " + l); 
                }
            }
        }
    }
}



}



}