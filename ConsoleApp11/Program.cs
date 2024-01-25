using System;
namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OneDimensionalArray temp = 
                new OneDimensionalArray(4, true);
            temp.Print();*/

            /*TwoDimensionalArray temp2 =
                new TwoDimensionalArray(4, 4, true);*/

             StepArray temp3 =
                 new StepArray(new int[] { 1, 2, 3 }, true);
            temp3.Print();
            temp3.ReverseIndex();
            
        }
    }
    
    
  


}

