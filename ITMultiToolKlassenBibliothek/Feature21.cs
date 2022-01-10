using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMultiToolKlassenBibliothek
{
    class Feature21
    {
        public static void Feature21Funcion1()
        {

            do
            {
                Console.Title = "Bandbreitenrechner";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Bandbreitenrechner <<<\n" +

                                 "hauptmenü um ins Hauptmenü zu gelangen\n" +
                                 "exit um das Programm zu beenden\n" +


                                  "------------------------------------------------------------------------------------\n\n");
                string strds = null;
                try
                {

                    int ds = 0;
                    do
                    {
                        Console.Write("Geben sie ihre Downloadgröße in MB ein:");
                        strds = Console.ReadLine();
                        ds = Convert.ToInt32(strds);
                        if (ds <= 0)
                        {
                            Console.WriteLine("Falsche Angabe Downloadgröße sollte über 0 liegen.");

                        }
                    } while (ds <= 0);

                    int igs = 0;
                    do {

                        Console.Write("Geben sie ihre Internetgeschwindigkeit in Mbit ein:");
                        strds = Console.ReadLine();
                        igs = Convert.ToInt32(strds);
                        if (igs <= 0)
                        {
                            Console.WriteLine("Falsche Angabe Internetgeschwindigkeit sollte über 0 liegen.");
                        }
                    } while (igs <= 0);

                    
                    Console.Write("Geben sie ihre Downloadgröße in MB ein:");
                    strds = Console.ReadLine();
                    int ds = Convert.ToInt32(strds);
                    Console.Write("Geben sie ihre Internetgeschwindigkeit in Mbit ein:");
                    strds = Console.ReadLine();
                    int igs = Convert.ToInt32(strds);

                    int tsec = ds * 8 / igs;
                    int std = tsec / 3600;
                    int rsec = tsec % 3600;
                    int min = rsec / 60;
                    int sec = rsec % 60;
                    Console.WriteLine("Ihr Donwload wird {0}h {1}m {2}s  dauern", std, min, sec);
                    Console.ReadLine();

                }
                catch (FormatException)
                {
                    if (strds == "exit")
                        Environment.Exit(0);
                    if (strds == "hauptmenü")
                        return;
                    Console.WriteLine("Falsche Eingabe Geben sie eine belibige Taste ein um wieder anzufangen");
                    Console.ReadKey();
                }
                finally
                {
                    Console.Clear();
                }




            } while (true);
        }

    }
}
