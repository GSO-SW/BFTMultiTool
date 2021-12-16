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
                Console.WriteLine("\t1 - Spannung als Energieaufteilung berechnen");
                Console.WriteLine("\t2 - Strom aus Ladungen je Zeit berechnen\n");
                Console.WriteLine("\t2 - Strom aus Ladungen je Zeit berechnen\n");
                Console.WriteLine("\t2 - Strom aus Ladungen je Zeit berechnen\n");
                Console.WriteLine("\t2 - Strom aus Ladungen je Zeit berechnen\n");
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

            double R;
            double I;
            double U;
            string choose;

            Console.WriteLine("Welchen Wert wollen sie berechenen:\n" + "(1) Die Spannung\n" + "(2) Die Stromstärke\n" + "(3) Den Widerstand");
            choose = Convert.ToString(Console.ReadLine());

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Geben Sie ihren Wert für den Widerstand (R) ein");
                    R = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben Sie nun noch ihren Wert für die Stromstärke (I) ein");
                    I = Convert.ToDouble(Console.ReadLine());

                    U = R * I;

                    Console.WriteLine("Ihr Wert für die Spannung beträgt {0} Volt!", U);
                    break;
                case "2":
                    Console.WriteLine("Geben Sie ihren Wert für den Spannung (U) ein");
                    U = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben sie nun noch Ihren Wert für den Widerstand (R) ein");
                    R = Convert.ToDouble(Console.ReadLine());

                    I = U / R;

                    Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                    break;
                case 3:
                    Console.WriteLine("Geben Sie ihren Wert für den Spannung (U) ein");
                    U = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben Sie nun noch ihren Wert für die Stromstärke (I) ein");
                    I = Convert.ToDouble(Console.ReadLine());

                    R = U / I;

                    Console.WriteLine("Ihr Wert für den Widerstand beträgt {0}", R);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;






            }




        }

        public static void ElektrischeLeistungBerechnen()
        {

            double P;
            double U;
            double I;
            string choose;

            Console.WriteLine("Welchen Wert wollen sie berechenen:\n" + "(1) Die elektrische Spannung \n" + "(2) Der elektrischem Strom\n" + "(3) Die Elektrische Leistung");
            choose = Convert.ToString(Console.ReadLine());

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Geben Sie ihren Wert für die Elektische Leistung (P) ein");
                    P = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben Sie nun noch ihren Wert für den elektrischem Strom (I) ein");
                    I = Convert.ToDouble(Console.ReadLine());

                    U = P / I;

                    Console.WriteLine("Ihr Wert für die elektrische Spannung beträgt {0} Volt!", U);
                    break;
                case "2":
                    Console.WriteLine("Geben Sie ihren Wert für die elektrische Leistung (P) ein");
                    P = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben sie nun noch Ihren Wert für den Widerstand (R) ein");
                    R = Convert.ToDouble(Console.ReadLine());

                    I = P / U;

                    Console.WriteLine("Ihr Wert für Stromstärke beträgt {0} Ampere", I);
                    break;
                case 3:
                    Console.WriteLine("Geben Sie ihren Wert für den Spannung (U) ein");
                    U = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Geben Sie nun noch ihren Wert für die Stromstärke (I) ein");
                    I = Convert.ToDouble(Console.ReadLine());

                    R = U / I;

                    Console.WriteLine("Ihr Wert für den Widerstand beträgt {0}", R);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;

            }


        }
        #endregion;
    }
}
