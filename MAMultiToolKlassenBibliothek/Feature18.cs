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
                Console.WriteLine("\n\nHier können sie ihre Scheitelpunktform in Normalform umwandeln.\n");

                submenü = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie einen der folgenden Rechenwege:\n");
                Console.WriteLine("\t1 - Scheitelpunktform in Normalform"); 
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        ScheitelpunktformNormalform();
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
            string HauptAusw;

            bool Exit = false;
            bool submenü;
            bool xserror = false;

            Console.WriteLine("ScheitelpunktformNormalForm");
            //Meine Erste Zeile
            string xnosave;
            do 
            {

           Console.WriteLine("Geben sie ihren xs Wert ein");
            
              xnosave = Console.ReadLine();


                switch (Console.ReadLine())
                {
                    case "x == ":
                        Console.Clear();
                        ScheitelpunktformNormalform();
                        break;

                    case "x == submenü":
                        Console.Clear();
                        submenü = true;
                        break;
                    case "x == Exit":
                        Exit = true;
                        break;


                    default:

                        if (int.TryParse(xnosave, out int zahl))
                        {
                            Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                            xserror = false;
                            decimal xsave = Decimal.Parse(xnosave);
                            Console.WriteLine(xsave);
                           
                        }
                        else
                        {
                            Console.WriteLine("Misserfolg geben sie Erneut etwas für xs ein!");
                            xserror = true;

                        }
                        break;
                        
                }
            
            } while (xserror == true);

                    xserror = false;


                     Console.ReadKey();
            bool yserror = false;
            string ynosave;
            do
            {

                Console.WriteLine("Geben sie ihren ys Wert ein");

                ynosave = Console.ReadLine();


                switch (Console.ReadLine())
                {
                    case "y == ":
                        Console.Clear();
                        ScheitelpunktformNormalform();
                        break;

                    case "y == submenü":
                        Console.Clear();
                        submenü = true;
                        break;
                    case "y == Exit":
                        Exit = true;
                        break;


                    default:





                        if (int.TryParse(ynosave, out int zahl))
                        {
                            Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                            yserror = false;
                            decimal ysave = Decimal.Parse(ynosave)
                            
                        }
                        else
                        {
                            Console.WriteLine("Misserfolg geben sie Erneut etwas für ys ein!");
                            yserror = true;

                        }
                        break;
                }

            } while (yserror == true);
            decimal ysave = Decimal.Parse(ynosave);
            yserror = false;
            

           
            ;
            Console.ReadKey();








        }


    }

}


