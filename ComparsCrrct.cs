using System;

class Program
{
    static void Main()
    {
 /*
        decimal number1 = 5.25745243896m;
        decimal number2 = 9.8544531763m;
   int number = 0x100;

        number1 += number2;
        Console.WriteLine(number1.ToString("#.###"));
    Console.WriteLine(number);


    string a="hello";
string b="world";
Object ob=a+b;
Console.WriteLine(ob+"llllllllllllllllllll");
Console.WriteLine(ob.ToString());


  string str1 = "The \"use\" of quotations causes difficulties.";        
        string str2 = "The " + "\u0022" + "use" + "\u0022" + " of quotations causes difficulties";
        Console.WriteLine(str2);

int x=5;
int y=10;
int temp=0;
temp=x;
x=y;
y=temp;
Console.WriteLine(x+" "+y);



Console.WriteLine("-------@@@########$$$$$ OPERATORS -------@@@########$$$$$ ");

bool p=true;
bool q=false;

Console.WriteLine(p && q);
Console.WriteLine(p || q);


*/
/*
int a=10;
long b=a;
Console.WriteLine("conversion from int to long {0}",b.GetType());

long c=20;
int d=(int)c;
Console.WriteLine("conversion from long to int not possible witout tyep casting {0}",a.GetType());

Object objct="i am indian";
String str=(string)objct;
Console.WriteLine("this is type casting obj to string");


char chr='a';
decimal dcml=chr;
Console.WriteLine(dcml);
Console.WriteLine(decimal.MaxValue);

*/

double myDouble = 5.1d; Console.WriteLine(myDouble); // 5.1 
 
long myLong = (long)myDouble; Console.WriteLine(myLong); // 5 
 

//Console.WriteLine(double.MaxValue +" " +myDouble.GetType());
//onsole.WriteLine(long.MaxValue +" "+ myLong.GetType());


/*
double d = 5e9d; // 5 * 10^9 
Console.WriteLine(d); // 5000000000 
int i = checked((int)d); // System.OverflowException 
Console.WriteLine(i);


int a=10;
String b=a.ToString();
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());

*/

// First example
 double d = 1 / 2;
  Console.WriteLine(d); // 0, not 0.5 
 
// Second example
 double half = (float)1 / 2; 
 Console.WriteLine(half); // 0.5 


    }
}