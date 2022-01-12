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
            decimal zahl=0;
            decimal xsave=0;
            decimal ysave=0;
            decimal asave=0;
            Console.WriteLine("Hallo\n Wollen sie zurück? geben sie submenü ein.\n wollen sie das Progamm komplett schließen? Geben sie Exit ein. Wollen sie das Feature benutzen? fahren sie fort.");
            do    
            {

                Console.WriteLine("ScheitelpunktformNormalForm");
                //Meine Erste Zeile
                string xnosave;

                do
                {

                    Console.WriteLine("Geben sie ihren xs Wert ein");

                    xnosave = Convert.ToString(Console.ReadLine());

                    switch (xnosave)
                    {


                        case "submenü":
                            Console.Clear();
                            submenü = true;
                            break;
                        case "Exit":
                            Environment.Exit(0);
                            break;


                        default:
                            if (decimal.TryParse(xnosave, out zahl))
                            {
                                Console.WriteLine("Erfolg! Die Eingabe war {0}.", zahl);
                                xserror = false;
                                xsave = Decimal.Parse(xnosave);

                            }
                            else
                            {
                                Console.WriteLine("Misserfolg geben sie Erneut etwas für xs ein!");
                                xserror = true;

                            }
                            break;

                    }

                } while (submenü == false && xserror == true);

                //xserror = false;

                string ynosave;
                if (submenü == false)
                {
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
                    
                    yserror = false;



                }

                if (submenü == false)
                {
                   

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
                   
                    aerror = false;







                    //f(x)=a*(x-xs)^2 +ys

                    //f(x)=ax^2 +bx+c
                    Console.WriteLine("so lautet nun ihre Scheitelpunktform:");
                    Console.WriteLine($"\nf(x)={asave}*(x-{xsave})^2 +{ysave}"); // s(-5/8)
                    

                    decimal klammer1 = 0;
                    decimal klammer2 = 0;
                    decimal klammer3 = 0;
                    decimal aMAL = 0;
                    decimal aMAL2 = 0;
                    decimal aMAL3 = 0;


                    if (xsave < 0)// erste binomische formel
                    {
                        klammer1 = xsave * 2;
                        klammer2 = xsave * xsave;

                        Console.WriteLine("Als erstes wird in der Klammer mithilfe der Binomischen Formel ausmultipliziert.");
                        Console.WriteLine($"f(x)={asave}*(x²{klammer1}x+{klammer2})+{ysave}");

                        aMAL = (asave * klammer1) * -1;
                        aMAL2 = asave * klammer2 + ysave;
                        Console.WriteLine("Dann wird die Klammer aufgelöst.");
                        Console.WriteLine($"Das ist nun ihre allgeimeine quadratische Funktion \nf(x)={asave}x²+{aMAL}+{aMAL2}");







                        Console.ReadLine();

                    }
                    else if (xsave > 0)//zweite binomische formel
                    {
                        klammer1 = xsave * 2;
                        klammer2 = xsave * xsave;

                        Console.WriteLine("Als erstes wird in der Klammer mithilfe der Binomischen Formel ausmultipliziert.");
                        Console.WriteLine($"f(x)={asave}*(x²-{klammer1}x+{klammer2})+{ysave}");

                        aMAL = asave * klammer1;
                        aMAL2 = asave * klammer2 + ysave;
                        Console.WriteLine($"f(x)={asave}x²-{aMAL}+{aMAL2}");

                        Console.ReadKey();
                    }
                }

                Console.Clear();
            } while (submenü == false);
         



        }


    }

}


