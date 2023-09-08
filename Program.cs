using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Zufallsgenerator
{
    internal class Program
    {
        private static int zufallszahl()
        {
            Random random = new Random();
            int randomnumber = random.Next(0, 100);
            return randomnumber;
        }

        static async Task Main(string[] args)//Code von ChatGPT
        {
            string antwort;
            int zahl;
            bool neurunde = true;
            

            

            while (neurunde) //Code von ChaptGPT
            {
                int randomnumber = zufallszahl();
                Console.WriteLine("Willst du eine neue Runde spielen? (ja/nein)");//Code von ChaptGPT
                string userInput = Console.ReadLine();//Code von ChaptGPT
                int i = 0;

                if (userInput.Equals("ja", StringComparison.OrdinalIgnoreCase))//Code von ChaptGPT
                {

                    do
                    {
                        Console.WriteLine("Sie können eine Zahl zwischen 1 und 100 erraten.");
                        antwort = Console.ReadLine();
                        if (int.TryParse(antwort, out zahl))
                        {

                            if (zahl > randomnumber)
                            {
                                Console.WriteLine("Die Zahl ist grösser als die Zufallszahl.");
                            }
                            if (zahl < randomnumber)
                            {
                                Console.WriteLine("Die Zahl ist kleiner als die Zufallszahl.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sie haben eine ungültige Eingabe gemacht, geben sie nur Zahlen an.");
                        }

                        i++;

                    } while (zahl != randomnumber);

                    PlayWinSound();
                    await Task.Delay(10000);//Code von ChatGPT
                    Console.WriteLine("¨Sie haben die Zufallszahl erraten.");
                    await Task.Delay(10000);//Code von ChatGPT
                    Console.WriteLine($"Sie haben {i}Versuche gebraucht.");
                    await Task.Delay(10000);//Code von ChatGPT
                }
                else if (userInput.Equals("nein", StringComparison.OrdinalIgnoreCase))//Code von ChaptGPT
                {
                    neurunde = false;
                    Console.WriteLine("Das Spiel wird beendet.");
                }
                else//Code von ChaptGPT
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte 'ja' oder 'nein' eingeben.");
                }
            }


        }

         

        static void PlayWinSound() //Code von ChatGPT
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\kochl\Desktop\IMS\BBB\Lernaterlier\2 Jahr\Einstieg\gewinnmusik.wav"); 
            player.Play();
        }

        
    }
}
