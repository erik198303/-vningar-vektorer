using System;

namespace Steg2
{
    class Program
    {
        /*
        Steg 2 - Skapa en string array med fem element. Användaren får mata in fem namn
        via en for-loop. Programmet skriver sedan ut dessa namn med hjälp av en for-loop. 
         */
        static void Main(string[] args)
        {
            string[] names = new string[5];
            


            
            for(int i = 0; i < names.Length; i++)
            {
                System.Console.Write("Mata in ett namn: ");
                string name = Console.ReadLine();
                names[i] += name;
            }
            
            for(int i = 0; i < names.Length; i++)  
            {
                System.Console.WriteLine(names[i]);
            }
        }
     
    

       
    } 
}   
