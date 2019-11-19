using System;

class Abcd{

public static void Main()
{
    String choice="";
    do{


int i=0;
int input=int.Parse(Console.ReadLine());
while(i<input)
{
i+=2;
Console.WriteLine("{0}",i);
}


do{
Console.WriteLine("you want to continue:yes or no");
choice=Console.ReadLine().ToUpper();
if(choice!="YES" && choice!="NO")
{
Console.WriteLine("invalid option");
}//if
}//do
while(choice!="YES" && choice!="NO");

}//do

while(choice=="YES");


}

}


