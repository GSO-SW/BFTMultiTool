using System;
using Figgle;




namespace ITMultiToolKlassenBibliothek
{
    public class ITMenue
    {
        public static void ITSubMenue()
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
                                  "                              >>> Informatik <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tzurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\n  Hier können Sie informatike Features benutzen, welche das Leben in der Berufsschule für Technik vereinfachen könnten.\nFolgende Möglichkeiten sind im Bereich Informatik möglich: \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Zahlensystem umrechnen");
                Console.WriteLine("\t2 - Daten ausrechnen und Sortieren");
                Console.WriteLine("\t3 - Witze Easter Egg\n");
                Console.WriteLine("\t4 - Bandbreit berechnen\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {
                    
                    case "1":
                        Console.Clear();
                        Feature9.Feature9Funcion1();
                        
                        break;

                    case "2":
                        Console.Clear();
                        Feauture10.Feature10Funcion1();

                        break;

                    case "3":
                        Console.Clear();
                        Feature11.Feature11Funcion1();

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
