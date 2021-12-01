using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PHMultiToolKlassenBibliothek
{
    class Feature5
    {
        public static void Feature5Funcion1()
        {
            Console.WriteLine("Feature5 SubSubMenue");

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
                                  "                              >>> Einheiten umrechnen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie Ihre Einheiten schnell umrechnen ohne das Sie große Rechnungen durchführen müssen. Das übernehmen wir für Sie.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Umrechnung von Einheiten. Wählen Sie aus:\n");
                Console.WriteLine("\t1 - SI-Einheiten");
                Console.WriteLine("\t2 - Maßeinheiten\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        SiEinheit.SiEinheiten();
                        break;

                    case "2":
                        Console.Clear();
                        SiEinheit.MassEinheiten();
                        break;
                    case "hauptmenü":
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
    }

    class SiEinheit
    {
        public static void SiEinheiten()
        {
            Console.WriteLine("Feature5 SubSubMenue");


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
                                  "                              >>> Umrechnung von Si-Einheiten <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie ihre gewünschte Einheit ein. Wir rechnen es für Sie automatisch um.\n\n");

                Hmenue = false;

                Console.WriteLine("Geben Sie ein, welche Einheit Sie umrechnen wollen:\n");
                Console.WriteLine("\t1 - Meter in Kilometer");
                Console.WriteLine("\t2 - Gramm in Kilogramm");
                Console.WriteLine("\t3 - Sekunden in Stunden");
                Console.WriteLine("\t4 - Ampere und Volt in Watt");
                Console.WriteLine("\t5 - Kelvin in Grad\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        string Meter;

                        // Hier noch 2 bool Exit und hmenue hinzufügen

                        do
                        {
                            Hmenue = false;
                            Console.WriteLine("Willkommen zur Berechnung von Meter in Kilometer.\n");
                            Console.WriteLine("Geben Sie bitte Ihre Daten in Meter an:");
                            Console.ReadKey();
                        } while (!Exit & !Hmenue);

                        if (Exit)
                            Environment.Exit(0);
                        break;



                    case "hauptmenü":
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
            }
            while (!Exit & !Hmenue);
            if (Exit)
                Environment.Exit(0);
        }



        public static void MassEinheiten()
        {
            Console.WriteLine("Feature5 SubSubMenue");


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
                                  "                              >>> Umrechnung von Maßeinheiten <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie ihre gewünschte Einheit ein. Wir rechnen es für Sie automatisch um.\n\n");

                Hmenue = false;

                Console.WriteLine("Geben Sie ein, welche Einheit Sie umrechnen wollen:\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "hauptmenü":
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
            }
            while (!Exit & !Hmenue);
            if (Exit)
                Environment.Exit(0);
        }
    }
}
