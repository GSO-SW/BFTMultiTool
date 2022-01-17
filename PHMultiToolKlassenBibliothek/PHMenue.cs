using System;
using Figgle;



namespace PHMultiToolKlassenBibliothek
{
    public class PHMenue
    {
        public static void PHSubMenue()
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
                                  "                              >>> Submenü Physik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie physikalische Features benutzen, welche das Leben in der Berufsschule für Technik vereinfachen könnten.\nFolgende Möglichkeiten sind im Bereich Physik möglich: \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Maßeinheiten umrechnen"); // Objekt Volumen berechnen     Schwerkraft berechnen      Maßeinheiten umrechnen      Feature8 (Noch nicht verfügbar)
                Console.WriteLine("\t2 - Schwerkraft berechnen");
                Console.WriteLine("\t3 - Feature8 (Noch nicht verfügbar)");
                Console.WriteLine("\t4 - Objekt Volumen berechnen\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {
                    
                    case "1":
                        Console.Clear();
                        Feature5.Feature5Funcion1();
                        break;

                    case "2":
                        Console.Clear();
                        Feature6.Feature6Funcion1();
                        break;

                    case "3":
                        Console.Clear();
                        Feature7.Feature7Funcion1();
                        break;

                    case "4":
                        Console.Clear();
                        Feature8.Feature8Funcion1();
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
