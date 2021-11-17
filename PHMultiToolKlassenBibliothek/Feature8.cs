using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace PHMultiToolKlassenBibliothek
{
    class Feature8
    {
        public static void Feature8Funcion1()
        {
            Console.WriteLine("Feature8 SubSubMenue");


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
                                  "                              >>> Objekt-Volumen Berechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie das Volumen vom Würfel, Kugel, Pyramide und Prisma berechnen.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Berechnung des Volumen von Objekt:\n");
                Console.WriteLine("\t1 - Würfel");
                Console.WriteLine("\t2 - Kugel");
                Console.WriteLine("\t3 - Pyramide");
                Console.WriteLine("\t4 - Prisma\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Volumberechnung.wuerfel();
                        break;

                    case "2":
                        Console.Clear();
                        Volumberechnung.Kugel();
                        break;

                    case "3":
                        Console.Clear();
                        Volumberechnung.Pyramide();
                        break;

                    case "4":
                        Console.Clear();
                        Volumberechnung.Prisma();
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










    class Volumberechnung
    {
        public static void wuerfel()
        {
            Console.WriteLine("Feature8 SubSubMenue");


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
                                  "                              >>> Berechnung des Volumen vom Würfel <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie Ihre Daten zur Berechnung des Würfels ein. Das Ergebnis wird automatisch für Sie berechnet.\n\n");

                Hmenue = false;

                Console.WriteLine("Angaben Ihres Würfels:\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();

                // Einsetzen des Codes

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


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }

        public static void Kugel()
        {
            Console.WriteLine("Feature8 SubSubMenue");


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
                                  "                              >>> Berechnung des Volumen von der Kugel <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie Ihre Daten zur Berechnung der Kugel ein. Das Ergebnis wird automatisch für Sie berechnet.\n\n");

                Hmenue = false;

                Console.WriteLine("Angaben Ihrer Kugel:\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();

                // Einsetzen des Codes

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


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }

        public static void Pyramide()
        {
            Console.WriteLine("Feature8 SubSubMenue");


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
                                  "                              >>> Berechnung des Volumen von der Pyramide <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie Ihre Daten zur Berechnung der Pyramide ein. Das Ergebnis wird automatisch für Sie berechnet.\n\n");

                Hmenue = false;

                Console.WriteLine("Angaben Ihrer Pyramide:\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();

                // Einsetzen des Codes

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


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }

        public static void Prisma()
        {
            Console.WriteLine("Feature8 SubSubMenue");


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
                                  "                              >>> Berechnung des Volumen von des Prisma <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: hauptmenü\t->\tZurück zum Hauptmenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier geben Sie Ihre Daten zur Berechnung des Prisma ein. Das Ergebnis wird automatisch für Sie berechnet.\n\n");

                Hmenue = false;

                Console.WriteLine("Angaben des Prisma:\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();

                // Einsetzen des Codes

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


            } while (!Exit & !Hmenue);

            if (Exit)
                Environment.Exit(0);
        }
    }
}
