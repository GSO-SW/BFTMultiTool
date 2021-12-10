using System;
using Figgle;



namespace WIMultiToolKlassenBibliothek
{
    public class WIMenue
    {
        public static void WISubMenue()
        {


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
                                  "                              >>> Wirtschaft Submenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Immobilienrechner");
                Console.WriteLine("\t2 - Zins und Zinseszins Rechner ");
                Console.WriteLine("\t3 - Amortization");
                Console.WriteLine("\t4 - Lohnsteuerberechnung");
                Console.WriteLine("\t5 - Fix- und Variablekosten\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {
                    
                    case "1":
                        Console.Clear();
                        Feature12.Feature12Funcion1();
                        break;

                    case "2":
                        Console.Clear();
                        Feature13.Feature13Funcion1();
                        break;

                    case "3":
                        Console.Clear();
                        Feature14.Feature14Funcion1();
                        break;

                    case "4":
                        Console.Clear();
                        Feature15.Feature15Funcion1();
                        break;

                    case "5":
                        Console.Clear();
                        Feature22.Feature22Funcion1();
                        break;
                    case "hauptmenü":
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
    }
}
