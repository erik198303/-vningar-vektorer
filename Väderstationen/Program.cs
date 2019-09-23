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
            //skapar en lista med 5 element. Alla har värde 0 från början.
            //Ligger utanför loop eftersom annars kommer dom få värde 0 efter varje loop runda.
            List<int> temperatur = new List<int>();
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            temperatur.Add(0);
            
            //Håller reda på total temperatur. Ligger utanför while loop, annars får den värde 0 vid varje loop runda.
            int totalTemperatur = 0;
try{
            while(true)
            {
            
            System.Console.WriteLine("[L]ägg till temperaturmätning");
            System.Console.WriteLine("[S]kriv ut alla temperaturer och medeltemperaturer");
            System.Console.WriteLine("[T]a bort temperaturmätning");
            System.Console.WriteLine("[A]vsluta");
            System.Console.Write("Välj: ");
            
            string menyVal = Console.ReadLine();
         
            switch(menyVal)
            {
                    //Case L/l
                    //Användaren får mata in 5st temperaturer.
                    //Temperaturer läggs in i list element. 
                    //Plussar även på inmatad temperatur i summan. 5 temperaturer blir summan av alla temperaturer.
                case "l":
                case "L":
                System.Console.WriteLine("Mata in fem(5st) temperaturer: ");
                for (int i = 0; i < temperatur.Count; i++)
                {
                    System.Console.Write("Mata in temperatur: ");
                    int inmatningTemperatur = Convert.ToInt32(Console.ReadLine());
                    temperatur[i] = inmatningTemperatur;
                    totalTemperatur += temperatur[i];
                    
                }
                break;

                //Case S/s
                //Kör inmatade temperaturer i en for loop för att skriva ut inmatade temperaturer.
                //Skriver även ut medeltemperaturen på inmatade temperaturer efter loop eftersom vi redan har summan av alla temperaturer.

                case "s":
                case "S":
                System.Console.WriteLine("Skriver ut temperaturer...");
                for (int i = 0; i < temperatur.Count; i++)
                {
                    System.Console.WriteLine("Inmatad temperatur: {0}",temperatur[i]);
                }
                System.Console.WriteLine("Medeltemperatur: {0}", (totalTemperatur / 5));
                break;


                //Case T/t
                //Nollställer alla element i listan
                //Detta görs via en forloop som sätter noll på lista 0-4.
                //*Nollställer total temperatur efter for loop efter det är onödigt att loopa det 0-värdet 5ggr i loopen.

                case "t":
                case "T":
                System.Console.WriteLine("*****Temperaturmätning nollställd!***** ");
                for(int i = 0; i < temperatur.Count; i++)
                {

                temperatur[i] = 0;
                       
                }
                //*Kommentar ovan.
                totalTemperatur = 0;
                break;

                case "a":
                case "A":
                default :
                System.Console.WriteLine("Hej då!");
                return;
              

                }
            }
                        }
                        catch(FormatException e){
                            System.Console.WriteLine("***Du måste skriva ett heltal!***");
                            System.Console.WriteLine("***Ge följande felmeddelande till IT-avdelning:***");
                            System.Console.WriteLine(e);
                        }

        }
    }
}
