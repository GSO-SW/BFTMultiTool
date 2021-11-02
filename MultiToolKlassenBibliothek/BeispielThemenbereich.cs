using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MultiToolKlassenBibliothek
{
    public class BeispielThemenbereich
    {
        public static void Menue()
        {
            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("BFTMultiTool"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                            >>>Beispielthemenbereich<<<\n" +
                              "------------------------------------------------------------------------------------\n\n");

            //Beschreibung der Software.
            Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm\n" +
                              "Eingabe: hauptmenü\t->\truft das Hauptmenü auf\n\n");


            string HauptAusw;

            bool Exit = false;
            bool Ecode;

            do
            {
                Ecode = false;
                (int, int) cPosBM = Console.GetCursorPosition();
                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Features aus:\n");
                Console.WriteLine("\t1 - Feature1");
                Console.WriteLine("\t2 - Feature2");
                Console.WriteLine("\t3 - Feature3");
                Console.WriteLine("\t4 - Feature4\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        MultiToolKlassenBibliothek.BeispielThemenbereich.Feature1();
                        break;

                    case "2":
                        Console.WriteLine("i");
                        break;

                    case "3":
                        Console.WriteLine("m");
                        break;

                    case "p":
                        Console.WriteLine("p");
                        break;
                    case "hauptmenü":
                        Console.Clear();
                        Hauptmenue.HauptmenueAufruf();
                        break;
                    case "exit":
                        Exit = true;
                        break;
                    default:
                        Ecode = true;

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();

                        ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (Exit == false & Ecode == true);

            if (Exit == true)
                Environment.Exit(0);
        }

        public static void Feature1()
        {
            Console.WriteLine("Feature1");
            Console.ReadKey();
            
        }

    }
}
