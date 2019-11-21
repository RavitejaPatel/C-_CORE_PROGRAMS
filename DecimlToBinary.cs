using System;

class DtoB
{

static void Main(string[] args)
{
    Console.Write("Enter number: ");
    int n = Int32.Parse(Console.ReadLine());    
  
  int arr; 
  int res=0;; 
int i=0;

int num; 

do{
    num=n;
    Console.WriteLine("+++++"+num);
    arr=n%2;
    Console.Write(arr);
    Console.WriteLine("****"+n);
    res=n/2;
     Console.WriteLine("****"+res);
n=res;
 Console.WriteLine("****-------------"+n);
i++;
}
while(num%2!=0);//num%2
 Console.WriteLine("****=====&&&&"+num);

//Console.WriteLine(arr.Length);

}



  
  
  
  /*
    string binary = Convert.ToString(n, 2);
    Console.WriteLine("Result is {0}", binary);

    Console.WriteLine(1/2);

*/
}


