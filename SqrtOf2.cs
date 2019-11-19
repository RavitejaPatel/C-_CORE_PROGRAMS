using System;
class Sqrtoff 
{ 
    // Returns floor of 
    // square root of x 
    static int floorSqrt(double x) 
    { 
        // Base cases 
        if (x == 0 || x == 1) 
            return x; 
  
        // Staring from 1, try all 
        // numbers until i*i is  
        // greater than or equal to x. 
        int i = 1, result = 1; 
          
        while (result <= x)  
        { 
            i++; 
            result = i * i; 
        } 
        return i - 1; 
    } 
  
    // Driver Code 
    static public void Main () 
    { 
        int x = 11; 
        Console.WriteLine((double)floorSqrt(x)); 
    } 
} 
  