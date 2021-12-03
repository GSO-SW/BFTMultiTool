using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAMultiToolKlassenBibliothek
{
    class Feature18
    {
        public static void Feature18Funcion1()
        {

            string HauptAusw;

            bool Exit = false;
            bool submenü;

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
                                  "                              >>> Mathematikrechner: Quadratische Funktionen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum MatheSubMenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können zwischen den Rechenwegen Scheitelpunktform in Normalform, oder Normalform in Scheitelpunktform wählen. \n");

                submenü = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie einen der folgenden Rechenwege:\n");
                Console.WriteLine("\t1 - Scheitelpunktform in Normalform");
                Console.WriteLine("\t2 - Normalform in Scheitelpunktform");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        ScheitelpunktformNormalform();

                        break;

                    case "2":
                        Console.Clear();
                        NormalformScheitelpunktform();

                        break;

                    case "submenü":
                        Console.Clear();
                        submenü = true;
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


            } while (!Exit & !submenü);

            if (Exit)
                Environment.Exit(0);
        }

        static void ScheitelpunktformNormalform()
        {
            Console.WriteLine("Scheitelpunktform");



        }

        static void NormalformScheitelpunktform()
        {
            Console.WriteLine("NormalformScheitelpunktdorm");



        }
    }
}

