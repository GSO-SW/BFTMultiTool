using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAMultiToolKlassenBibliothek
{
    class Feature19
    {
        public static void Feature19Funcion1()
        {
            Console.WriteLine("Featur19 SubSubMenue");

            string HauptAusw;

            bool Exit = false;
            bool submenü;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

               
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematikrechner: Flächenberechnung verschiedener Formen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum MatheSubMenü");

                
                Console.WriteLine("\n\nHier können Sie zwischen vielen verschiedenen Möglichkeiten wählen, zum Flächenberechnen von verschiedenen Formen. \n");

                submenü = false;

               
                Console.WriteLine("Wählen Sie eine der folgenden möglichkeiten zum Flächeninhalt berechnen:\n");
                Console.WriteLine("\t1 -Flächeninhalt eines Quadratsberechnen ");
                Console.WriteLine("\t2 -Flächeninhalt eines rechtecks berechnen ");
                Console.WriteLine("\t3 - Flächeninhalt eines allgemeinem Dreieck berechnen");
                Console.WriteLine("\t4 - Flächeninhalt eines rechtwinkligem Dreieck berechnen");
                Console.WriteLine("\t5 - Flächeninhalt eines gleichwinkligem Dreieck berechnen");
                Console.WriteLine("\t6 - Flächeninhalt eines gleichseitigem Dreieck berechnen");
                Console.WriteLine("\t7 - Flächeninhalt eines Trapezes berechnen");
                Console.WriteLine("\t8 - Flächeninhalt eines Parallelogram berechnen");
                Console.WriteLine("\t9 - Flächeminhalt einer Raute berechnen");
                Console.WriteLine("\t10 - Flächeninhalt eines Kreises berechnen");


                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Quadratberechnen();

                        break;

                    case "2":
                        Console.Clear();
                        Rechteckberechen();

                        break;

                    case "3":
                        Console.Clear();
                        AllgemeinesDreieck();

                        break;

                    case "4":
                        Console.Clear();
                        rechtwinkligesDreieck();

                        break;

                    case "5":
                        Console.Clear();
                        gleichwinkligesDreieck();

                        break;

                    case "6":
                        Console.Clear();
                        gleichseitigesDreieck();

                        break;

                    case "7":
                        Console.Clear();
                        Trapez();

                        break;

                    case "8":
                        Console.Clear();
                        Parallelogram();

                        break;

                    case "9":
                        Console.Clear();
                        Raute();

                        break;

                    case "10":
                        Console.Clear();
                        Kreis();

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

        static void Quadratberechnen()
        {
            Console.WriteLine("Quadratberechnen");
        }

        static void Rechteckberechen()
        {
            Console.WriteLine("Rechteckberechnen");
        }

        static void AllgemeinesDreieck()
        {
            Console.WriteLine("AllgemeinesDreieck");
        }

        static void rechtwinkligesDreieck()
        {
            Console.WriteLine("rechwinkligesDreieck");
        }

        static void gleichwinkligesDreieck()
        {
            Console.WriteLine("gleichwinkligesDreieck");
        }

        static void gleichseitigesDreieck()
        {
            Console.WriteLine("gleichseitigesDreieck");
        }

        static void Trapez()
        {
            Console.WriteLine("Trapez");
        }

        static void Parallelogram()
        {
            Console.WriteLine("Parallelogram");
        }

        static void Raute()
        {
            Console.WriteLine("Raute");

        }

        static void Kreis()
        {
            Console.WriteLine("Kreis");
        }
    }

}


        
    
