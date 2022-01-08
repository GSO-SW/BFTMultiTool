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
                Console.ForegroundColor = ConsoleColor.Green;
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
                Console.WriteLine("\n\nWillkommen in dem SubSubmenü Ohm'sches und Leistungs Gesetz berechnen!\n\n"
                                       + "In diesem Untermenü können sie alleine mit der Eingabe zweier Ziffern, alle Werte der Formel des Ohm'schen und des Leistungs Gesetzes ermitteln!\n\n");

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

                        Console.ResetColor();
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

            double R;
            double I;
            double U;
            string choose;
            bool Exit = false;
            bool subsubmenü;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Berechnung Ohm'sches Gesetz <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Welchen Wert wollen sie berechnen:\n" + "Die Spannung (1)\n" + "Die Stromstärke (2)\n" + "Den Widerstand (3)\n"
                     + "Wenn sie das Programm beenden wollen (Exit)\n" + "Wenn sie zu dem vorherigen Menü zurückkehren wollen (submenü)");
                choose = Convert.ToString(Console.ReadLine());
                                
                subsubmenü = false;

                switch (choose)
                {
                    case "1":

                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Geben Sie ihren Wert für den elektrischen Widerstand (R) ein");
                            R = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischem Strom (I) ein");
                            I = Convert.ToDouble(Console.ReadLine());

                            U = R * I;

                            Console.WriteLine("Ihr Wert für die elektrische Spannung beträgt {0} Volt!", U);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;

                    case "2":
                        try
                        {

                            Console.Clear();
                            Console.WriteLine("Geben Sie ihren Wert für den elektrischen Widerstand (R) ein");
                            R = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben sie nun noch Ihren Wert für die elektrische Spannung (U) ein");
                            U = Convert.ToDouble(Console.ReadLine());

                            I = U / R;

                            Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Geben Sie ihren Wert für die elektrische Spannung (U) ein");
                            U = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischen Strom (I) ein");
                            I = Convert.ToDouble(Console.ReadLine());

                            R = U / I;

                            Console.WriteLine("Ihr Wert für den elektrischen Widerstand beträgt {0}", R);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "Exit":
                                                
                        Console.Clear();
                        Exit = true;
                        break;

                    case "submenü":
                       
                        Console.Clear();
                        subsubmenü = true;             
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();                                           
                        Console.Clear();
                        break;

                }

                Console.ResetColor();
                
            } while (!Exit & !subsubmenü);

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
            bool subsubmenü;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Berechnung elektrisches Gesetz <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Welchen Wert wollen sie berechnen:\n" + "Die elektrische Spannung (1) \n" + "Der elektrischem Strom (2)\n" + "Die elektrische Leistung (3)\n"
                    + "Wenn sie das Programm beenden wollen (Exit)\n" + "Wenn sie zu dem vorherigen Menü zurückkehren wollen (subsubmenü)");
                choose = Convert.ToString(Console.ReadLine());
                                
                subsubmenü = false;

                switch (choose)
                {
                    case "1":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Geben Sie ihren Wert für die elektische Leistung (P) ein");
                            P = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischem Strom (I) ein");
                            I = Convert.ToDouble(Console.ReadLine());

                            U = P / I;

                            Console.WriteLine("Ihr Wert für die elektrische Spannung beträgt {0} Volt!", U);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "2":
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Geben Sie ihren Wert für die elektrische Leistung (P) ein");
                            P = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Geben sie nun noch Ihren Wert für die elektrische Spannung (U) ein");
                            U = Convert.ToDouble(Console.ReadLine());

                            I = P / U;

                            Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        try 
                        { 
                        Console.Clear();
                        Console.WriteLine("Geben Sie ihren Wert für die elektrische Spannung (U) ein");
                        U = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischen Strom (I) ein");
                        I = Convert.ToDouble(Console.ReadLine());

                        P = U * I;

                        Console.WriteLine("Ihr Wert für die elektrische Leistung beträgt {0} Watt", P);
                        Console.ReadKey();
                        Console.Clear();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Bitte geben sie nur Zeichen in dem richtigen Format ein");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    
                    case "Exit":
                        Console.Clear();
                        Exit = true;
                        break;
                   
                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine("Ungültige Eingabe");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

                Console.ResetColor();

            } while(!Exit & !subsubmenü);

            if (Exit)
                Environment.Exit(0);
        }
        #endregion;
    }
}
