using System;
class Coffee{

public static void Main()
{
string choice="";
int cost=0;
String option="yes";

Console.WriteLine("select ur coffee \n1.samll\n2.medium\n3.large\n");
choice=Console.ReadLine().ToLower();

switch(choice)
{

case "small":
cost=cost+1;
Console.WriteLine("u selected: "+choice);
break;

case "medium":
cost=cost+2;
Console.WriteLine("u selected: "+choice);
break;

case "large":
cost=cost+3;
Console.WriteLine("u selected: "+choice);
break;


default:
Console.WriteLine("ur choice {0} is invalid",choice);
break;

}//switch

Console.WriteLine("hello cx thx for shop..u have spent {0} for {1}",cost,choice);

    Console.WriteLine("dear CX do you want to continue shopping?\n1.YES\n2.NO\n");

do//inner do
{

option=Console.ReadLine().ToLower();

    if(option!="yes" && option!="no")
    {
Console.WriteLine("dear CX please enter correct choice?\n1.YES\n2.NO\n");
    }//if
}//do
while(option!="yes" && option!="no");
//inner do and while

 



}
}
