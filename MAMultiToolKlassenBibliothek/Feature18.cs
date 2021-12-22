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
                        Environment.Exit(0);
                        break;

                    default:

                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!submenü);

        }

        static void ScheitelpunktformNormalform()
                       
        
        {
            string HauptAusw;;
            bool submenü = false;
            bool xserror = false;
            decimal zahl;
            decimal xsave;
            decimal ysave;
            decimal asave;

            Console.WriteLine("ScheitelpunktformNormalForm");
            //Meine Erste Zeile
            string xnosave;
            
            do 
            {

           Console.WriteLine("Geben sie ihren xs Wert ein");
            
              xnosave = Convert.ToString(Console.ReadLine());
               
                switch(xnosave)
                {
                   

                    case "submenü":
                        Console.Clear();
                        submenü = true;
                        break;
                    case "Exit":
                        Environment.Exit(0);
                        break;


                    default:
                        if (decimal.TryParse(xnosave, out  zahl))
                        {
                            Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                            xserror = false;
                            xsave = Decimal.Parse(xnosave);
                            Console.WriteLine(xsave);
                           
                        }
                        else
                        {
                            Console.WriteLine("Misserfolg geben sie Erneut etwas für xs ein!");
                            xserror = true;

                        }
                        break;
                        
                }
            
            } while (submenü==false && xserror==true);

            //xserror = false;
           
            string ynosave;
            if (submenü==false)
            {
                Console.ReadKey();
                bool yserror = false;
                
                

                do
                {

                    Console.WriteLine("Geben sie ihren ys Wert ein");

                    ynosave = Console.ReadLine();


                    switch (ynosave)
                    {


                        case "submenü":
                            Console.Clear();
                            submenü = true;
                            break;
                        case "Exit":
                            Environment.Exit(0);
                            break;


                        default:





                            if (decimal.TryParse(ynosave, out zahl))
                            {
                                Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                                yserror = false;
                                ysave = Decimal.Parse(ynosave);

                            }
                            else
                            {
                                Console.WriteLine("Misserfolg geben sie Erneut etwas für ys ein!");
                                yserror = true;

                            }
                            break;
                    }

                } while (yserror == true && submenü == false);
                ysave = decimal.Parse(ynosave);
                yserror = false;
                
                
               
            }
            
            if (submenü==false)
            {
                Console.ReadKey();

                string anosave;
                bool aerror = false;
               
                do
                {

                    Console.WriteLine("Geben sie ihren a Wert ein");

                    anosave = Console.ReadLine();


                    switch (anosave)
                    {


                        case "submenü":
                            Console.Clear();
                            submenü = true;
                            break;
                        case "Exit":
                            Environment.Exit(0);
                            break;


                        default:





                            if (decimal.TryParse(anosave, out zahl))
                            {
                                Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                                aerror = false;
                                asave = Decimal.Parse(anosave);

                            }
                            else
                            {
                                Console.WriteLine("Misserfolg geben sie Erneut etwas für ys ein!");
                                aerror = true;

                            }
                            break;
                    }

                } while (aerror == true && submenü == false);
                asave = Decimal.Parse(anosave);
                aerror = false;
                

                Console.WriteLine(asave);
                

                

                

            }
            
            

        }


    }

}


