using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHMultiToolKlassenBibliothek
{
    class Feature7
    {
        public static void Feature7Funcion1()
        {
            Console.WriteLine("Feature7 SubSubMenue");


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
                                  "                              >>> Aufbau und Struktur der Materie <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: submenue\t->\tZurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier finden sie die Infos zur Aufbau und Struktur der Materie.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Infos zur Aufbau und Struktur der Materie:\n");
                Console.WriteLine("\t1 - Aufbau");
                Console.WriteLine("\t2 - Struktur");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Aufbau();
                        break;

                    case "2":
                        Console.Clear();
                        Struktur();
                        break;



                    case "submenue":
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
            //-------------------------------------------------------------------------------------------------
            //                                  Aufbau
            public static void Aufbau()
            {
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
                                      "                              >>> Aufbau der Materie <<<\n" +
                                      "------------------------------------------------------------------------------------\n\n");

                    Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                    Console.WriteLine("Eingabe: submenue\t->\tZurück zum Submenü");

                    //Beschreibung der Software.
                    Console.WriteLine("\n\nAufbau.\n\n");

                    Hmenue = false;
                    //Eingabeaufforderung 
                    Console.WriteLine("Welche Information zum Aufbau?:\n");
                    Console.WriteLine("\t1 - Das Periodensystem der Elemente");
                    Console.WriteLine("\t2 - Vier Grundfläche der Physik");
                    Console.WriteLine("\t3 - Woher kommt die Masse?");
                    Console.Write("Eingabe:");
                    HauptAusw = Console.ReadLine();

                    switch (HauptAusw)
                    {

                        case "1":
                            Console.Clear();
                            PeriodensystemDerElemente();
                            break;

                        case "2":
                            Console.Clear();
                            VierGrundflächeDerPhysik();
                            break;

                        case "3":
                            Console.Clear();
                            WoherKommtDieMasse();
                            break;


                        case "submenue":
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


        public static void PeriodensystemDerElemente()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Das Periodensystem der Elemente <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("");




        }

        public static void VierGrundflächeDerPhysik()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Vier Grundfläche der Physik <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");





        }

        public static void WoherKommtDieMasse()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Woher kommt die Masse ? <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");




        }


        //-------------------------------------------------------------------------------------------------
        //                                  Struktur
        public static void Struktur()
        {
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
                                  "                              >>> Strukur der Materie <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tBeendet das Programm");
                Console.WriteLine("Eingabe: submenue\t->\tZurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nAufbau.\n\n");

                Hmenue = false;
                //Eingabeaufforderung 
                Console.WriteLine("Welche Information zur Struktur?:\n");
                Console.WriteLine("\t1 - Atomkern");
                Console.WriteLine("\t2 - Kernumwandlung und Radioaktivität");
                Console.WriteLine("\t3 - Kernspaltung");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Atomkern();
                        break;

                    case "2":
                        Console.Clear();
                        KernUndRadio();
                        break;

                    case "3":
                        Console.Clear();
                        Kernspaltung();
                        break;


                    case "submenue":
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
            public static void Atomkern()
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> ´Atomkern <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");





            }

            public static void KernUndRadio()
            {
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> ´Kernumwandlung und Radioaktivität <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");





            }

        public static void Kernspaltung()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Kernspaltung <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");




        }
        
       
    }
      
}