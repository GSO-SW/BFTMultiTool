using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAMultiToolKlassenBibliothek
{
    class Feature17
    {
        public static void Feature17Funcion1()
        {
            Console.WriteLine("Feature17 SubSubMenue");


            string HauptAusw;

            bool Exit = false;
            bool Submenü;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();


                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematikrechner: Lineare Funktionen  <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");


                Console.WriteLine("\n\nHier können Sie zwischen Nullstellen und einer Wertetabelle auswählen, zu Linearen Funktionen!\n\n");

                Submenü = false;


                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Nullstellen");
                Console.WriteLine("\t2 - Wertetabelle");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Nullstellen();

                        break;

                    case "2":
                        Console.Clear();
                        Wertetabelle();

                        break;

                    case "submenü":
                        Console.Clear();
                        Submenü = true;
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


            } while (!Exit & !Submenü);

            if (Exit)
                Environment.Exit(0);


            static void Nullstellen()
            {
                Console.WriteLine("Nullstellen");

              


            }




            static void Wertetabelle()
            {
                Console.WriteLine("Wertetabelle");
            }


        }

        }
        
    }











