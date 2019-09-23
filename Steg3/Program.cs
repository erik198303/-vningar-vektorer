using System;

namespace Steg3
{
    class Program
    {
        /*
        Steg 3 - Efter att alla namn skrivits ut, ska användaren kunna skriva ett index och
        därefter ett annat namn. Personen på detta index i vektorn byts då ut och alla
        namn skrivs ut igen. Om användaren istället skriver ”q” eller ”Q” så avslutas
        programmet direkt.
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
                System.Console.WriteLine("Namn {0}: {1}",i,names[i]);
                
            }
            
            string quit = "";
            
            System.Console.WriteLine("**Vill du avsluta program? Tryck q/Q**");
            System.Console.WriteLine("Annars trycker du på valfri tangent för att fortsätta");
            quit = Console.ReadLine();

            if(quit == "Q" || quit == "q")
            {
                System.Console.WriteLine("Program avslutas!");
                return;
               
            }
           
            System.Console.Write("Välj index som du vill byta namn på, 0-4: ");
            
          try{  
            int valAvIndex = Convert.ToInt32(Console.ReadLine());
            names[valAvIndex] = "";
            System.Console.Write("Skriv in nytt namn på valt index(Index {0}): ",valAvIndex);
            names[valAvIndex] = Console.ReadLine();
          }
            catch (Exception e){
              System.Console.WriteLine("Du får bara välja mellan 0-4!");
              System.Console.WriteLine("Ge följande felkod till IT-avdelning:");
              System.Console.WriteLine(e);
              return;
            }
            

          
            for(int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine("Namn {0}: {1}",i,names[i]);
            }
            
   

        }













        
    }
}
