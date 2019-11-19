using System;
class i{

public static void Main()
{

int? ticOnSale=null;
int availTic;

if(ticOnSale == null)
{
    availTic=0;
    Console.WriteLine("availtickets:0");
}

else{

availTic = (int)ticOnSale;
Console.WriteLine(availTic);

}

}



}
