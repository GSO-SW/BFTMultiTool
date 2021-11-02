using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MultiToolKlassenBibliothek
{
    public class Hauptmenue
    {
        public static void HauptmenueAufruf()
        {
            Console.WriteLine();

            //ASCII art Logo wird erzeugt.
            Console.WriteLine
                (FiggleFonts.Slant.Render("BFTMultiTool"));

            //Konsolentitel wird geändert.
            Console.Title = "BFTMultiTool";

            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> Hauptmenü <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Eingabe: exit\t->\tbeendet das Programm");

            //Beschreibung der Software.
            Console.WriteLine("\n\nMit der Software 'BFTMulti-Tool' sollen wiederkehrende oder besonders aufwendige\n" +
                              "Aufgabenaus dem schulischen Kontext erleichtert oder gelöst werden. Diese Aufgaben\n" +
                              "ergeben sich aus den Problemstellungen aus dem Unterricht der Berufsfachschule für Technik.\n\n");

            string HauptAusw;

            bool Exit = false;
            bool Ecode;

            do
            {
                Ecode = false;
                (int, int) cPosBM = Console.GetCursorPosition();
                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\te - Elektrotechnik");
                Console.WriteLine("\ti - Informatik");
                Console.WriteLine("\tm - Mathematik");
                Console.WriteLine("\tp - Physik\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine().ToLower();

                switch (HauptAusw)                                                              
                {                                                                       
                    case "e":
                        Console.Clear();
                        MultiToolKlassenBibliothek.BeispielThemenbereich.Menue();                                                   
                        break;

                    case "i":
                        Console.WriteLine("i");
                        break;

                    case "m":
                        Console.WriteLine("m");
                        break;

                    case "p":
                        Console.WriteLine("p");
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
    }
}
