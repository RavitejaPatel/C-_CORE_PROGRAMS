//A given company has name, address, phone number, fax number, web site and manager.
// The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.

using System;

class Exer4
{

static void Main(string[] args)
{    
    double sum=1.0;
    
    Console.WriteLine("{0:F4}", sum);
}


}

/*
   static void Main(string[] args)
        {
            Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);
        }


*/



//Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an
 //integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.
/*
 public static void Main()
 {  
    Console.Write("Enter first number: ");
    int a = Int32.Parse(Console.ReadLine());
    Console.Write("Enter second number: ");
    int b = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b));

//Console.WriteLine(" {0} >= {1}", Math.Max(a,b),Math.Min(a,b));


}
}


public static void Main()
{

//Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.
int a,b,c,d,e;

bool parseSuccess=false;

do{
    Console.WriteLine("enter no");

 parseSuccess=int.TryParse(Console.ReadLine(),out a);
 Console.WriteLine(parseSuccess);
}
while(!parseSuccess);

do{
    Console.WriteLine("enter no");

 parseSuccess=int.TryParse(Console.ReadLine(),out e);
 Console.WriteLine(parseSuccess);
}
while(!parseSuccess);



do{
    Console.WriteLine("enter no");

 parseSuccess=int.TryParse(Console.ReadLine(),out b);
 Console.WriteLine(parseSuccess);
}
while(!parseSuccess);


do{
    Console.WriteLine("enter no");

 parseSuccess=int.TryParse(Console.ReadLine(),out c);
 Console.WriteLine(parseSuccess);
}
while(!parseSuccess);


do{
    Console.WriteLine("enter no");

 parseSuccess=int.TryParse(Console.ReadLine(),out d);
 Console.WriteLine(parseSuccess);
}
while(!parseSuccess);



Console.WriteLine(a+b+c+d+e);

}

}




*/