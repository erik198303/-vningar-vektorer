using System;

namespace Steg1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2, num3, num4, num5;
            System.Console.Write("Mata in tal 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());   
            System.Console.Write("Mata in tal 2: ");
            num2 = Convert.ToInt32(Console.ReadLine()); 
            System.Console.Write("Mata in tal 3: ");
            num3 = Convert.ToInt32(Console.ReadLine()); 
            System.Console.Write("Mata in tal 4: ");
            num4 = Convert.ToInt32(Console.ReadLine()); 
            System.Console.Write("Mata in tal 5: ");
            num5 = Convert.ToInt32(Console.ReadLine());

          



            int[] nums = new int[5];
            nums[0] = num1;
            nums[1] = num2;
            nums[2] = num3;
            nums[3] = num4;
            nums[4] = num5;
        
           int sum = 0;

           for(int i = 0; i<nums.Length; i++)
        
            {
                sum = sum +nums[i];
            }
            System.Console.WriteLine("Summan av talen är {0}", sum);




            
            
            
        }
    }
}
