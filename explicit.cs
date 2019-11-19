
// C# program to illustrate incompatible data  
// type for explicit type conversion 
using System; 
namespace Casting{ 
  
class GFG { 
  
        // Main Method 
        public static void Main(String []args) 
        { 
            double d = 765.12; 
  
            // Incompatible Data Type 
            int ibps =(int)d; 
              
            // Display Result     
            Console.WriteLine(ibps); 
  
  
  //explicit

  float ft=217.25F;
  int it=(int)ft;
  Console.WriteLine("explicit"+it);

        } 
} 
}