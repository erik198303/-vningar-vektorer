using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Väderstationen
{
    class Program
    {
        /*
        Väderstationen - Gör ett program med funktionerna i denna
        skärm. Varje tempraturmätning ska sparas i en Lista.
         */
        static void Main(string[] args)
        {
            List<int> temperatur = new List<int>();
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            
            int totalTemperatur = 0;
            

            while(true)
            {
            System.Console.WriteLine("[L]ägg till temperaturmätning");
            System.Console.WriteLine("[S]kriv ut alla temperaturer och medeltemperaturer");
            System.Console.WriteLine("[T]a bort temperaturmätning");
            System.Console.WriteLine("[A]vsluta");
            
            
            

            
            
            string menyVal = Console.ReadLine();

            switch(menyVal)
            {
            
                
                case "l":
                case "L":
                System.Console.WriteLine("Mata in fem(5st) temperatur: ");
                for (int i = 0; i < temperatur.Count; i++)
                {
                    System.Console.Write("Mata in temperatur: ");
                    int inmatningTemperatur = Convert.ToInt32(Console.ReadLine());
                    temperatur[i] = inmatningTemperatur;
                    totalTemperatur += temperatur[i];
                    
                }
                break;

                case "s":
                case "S":
                System.Console.WriteLine("Skriver ut temperaturer...");
                for (int i = 0; i < temperatur.Count; i++)
                {
                    System.Console.WriteLine("Inmatade temperaturer: {0}",temperatur[i]);
                }
                System.Console.WriteLine("Medeltemperatur: {0}", (totalTemperatur / 5));
                break;

                case "t":
                case "T":
                System.Console.WriteLine("**Temperaturmätning nollställd!** ");
                for(int i = 0; i < temperatur.Count; i++)
                {
                    temperatur[i] = 0;
                    totalTemperatur = 0;
                    
                }

                break;

                default:
                System.Console.WriteLine("Hej då!");
                return;
              

                }
            }
        }
    }
}
