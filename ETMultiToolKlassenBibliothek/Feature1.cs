using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature1
    {

        #region Subsubmenü
        public static void Feature1Funcion1()              
        {
            Console.Clear();
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
                                  "                              >>> Berechnungen Ohm'sches & Leistungsgesetz SubSubmenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Ohm'sches Gesetz berechnen");
                Console.WriteLine("\t2 - Leistungsgesetz berechnen\n");
                         
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        OhmschesGesetzberechnen();
                        break;

                    case "2":
                        Console.Clear();
                        ElektrischeLeistungBerechnen();
                        break;
                                          
                    case "submenü":
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
        #endregion

        #region Rechnungen
        public static void OhmschesGesetzberechnen() 
        {

            Console.Clear();

            double P;
            double I;
            double U;
            string choose;
            bool Exit = false;
            bool submenü;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Berechnung Ohm'sches Gesetz <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Welchen Wert wollen sie berechnen:\n" + "Die Spannung (1)\n" + "Die Stromstärke (2)\n" + "Den Widerstand (3)\n"
                     + " Wenn sie das Programm beenden wollen (Exit)\n" + "Wenn sie zu dem vorherigen Menü zurückkehren wollen (submenü)");
                choose = Convert.ToString(Console.ReadLine());

                Console.ResetColor();

                submenü = false;

                switch (choose)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Geben Sie ihren Wert für die Elektische Leistung (P) ein");
                        P = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischem Strom (I) ein");
                        I = Convert.ToDouble(Console.ReadLine());

                        U = P / I;

                        Console.WriteLine("Ihr Wert für die elektrische Spannung beträgt {0} Volt!", U);
                        Console.ReadKey();
                        Console.ResetColor();
                        Console.Clear();

                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geben Sie ihren Wert für die elektrische Leistung (P) ein");
                        P = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben sie nun noch Ihren Wert für die elektrische Spannung (U) ein");
                        U = Convert.ToDouble(Console.ReadLine());

                        I = P / U;

                        Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geben Sie ihren Wert für die elektrische Spannung (U) ein");
                        U = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischen Strom (I) ein");
                        I = Convert.ToDouble(Console.ReadLine());

                        P = U * I;

                        Console.WriteLine("Ihr Wert für die elektrische Leistung beträgt {0}", P);
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "Exit":
                        Console.Clear();
                        Exit = true;
                        break;
                    case "submenü":
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

                
            } while (!Exit & !submenü);

            if (Exit)
                Environment.Exit(0);

        }

        public static void ElektrischeLeistungBerechnen()
        {

            Console.Clear();

            double P;
            double U;
            double I;
            string choose;
            bool Exit = false;
            bool submenü;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Berechnung Elektrisches Gesetz <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Welchen Wert wollen sie berechnen:\n" + "Die elektrische Spannung (1) \n" + "Der elektrischem Strom (2)\n" + "Die Elektrische Leistung (3)\n"
                    + " Wenn sie das Programm beenden wollen (Exit)\n" + "Wenn sie zu dem vorherigen Menü zurückkehren wollen (submenü)");
                choose = Convert.ToString(Console.ReadLine());

                Console.ResetColor();

                submenü = false; 

                switch (choose)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geben Sie ihren Wert für die Elektische Leistung (P) ein");
                        P = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischem Strom (I) ein");
                        I = Convert.ToDouble(Console.ReadLine());

                        U = P / I;
                                               
                        Console.WriteLine("Ihr Wert für die elektrische Spannung beträgt {0} Volt!", U);
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geben Sie ihren Wert für die elektrische Leistung (P) ein");
                        P = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben sie nun noch Ihren Wert für die elektrische Spannung (U) ein");
                        U = Convert.ToDouble(Console.ReadLine());

                        I = P / U;

                        Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Geben Sie ihren Wert für die elektrische Spannung (U) ein");
                        U = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischen Strom (I) ein");
                        I = Convert.ToDouble(Console.ReadLine());

                        P = U * I;

                        Console.WriteLine("Ihr Wert für die elektrische Leistung beträgt {0} Watt", P);
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "Exit":
                        Console.Clear();
                        Exit = true;
                        break;
                    case "subsubmenü":
                        Console.Clear();

                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

            } while(!Exit & !submenü);

            if (Exit)
                Environment.Exit(0);
        }
        #endregion;
    }
}
