using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature1
    {

        #region Subsubmenü
        public static void Feature1Funcion1()              
        {
            Console.Clear();
            string HauptAusw;

            bool Exit = false;
            bool Hmenue;
            

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                //ASCII art Logo wird erzeugt.
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                //Konsolentitel wird geändert.
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Einheitenbiliothek + Berechnungen SubSubmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Spannung als Energieaufteilung berechnen");
                Console.WriteLine("\t2 - Strom aus Ladungen je Zeit berechnen\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        //SpannungalsEnergieaufteiling();
                        break;

                    case "2":
                        Console.Clear();
                        StromausLadungjeZeit();
                        break;
                                          
                    case "submenü":
                        Console.Clear();
                        Hmenue = true;
                        break;
                   
                    case "exit":
                        Exit = true;
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }
        #endregion

        #region Rechnungen
        public static void SpannungalsEnergieaufteiling() 
        { 
               
               
        }

        public static void StromausLadungjeZeit() 
        {
            double time;
            double charge;

            Console.WriteLine("Geben sie die Zeit in Sekunden ein!");
            time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Geben sie nun noch ihren Wert für die elektrische Ladung in Ampere ein!");
            charge = Convert.ToDouble(Console.ReadLine());

            double stromstärke = charge / time;

            Console.WriteLine("Die Strom stärke beträgt: " + stromstärke);
            Console.ReadKey();
            Console.Clear();      
        }
        #endregion
   
               

    }
}
