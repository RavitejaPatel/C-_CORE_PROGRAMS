using System;
class test
{
    public static void Main()
    {
string choice="";

choice=Console.ReadLine();

do{
if(choice=="yes" || choice == "no")
{
    Console.WriteLine("yes DOOO");
}
}
while(choice=="yes");

Console.WriteLine("break");

    }
}