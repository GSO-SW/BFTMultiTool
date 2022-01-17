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
                Console.WriteLine("Eingabe: submenue\t->\tZurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nHier können Sie das Volumen vom Würfel, Kugel, Pyramide und Prisma berechnen.\n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Berechnung des Volumen von Objekt:\n");
                Console.WriteLine("\t1 - Kugel");
                Console.WriteLine("\t2 - Pyramide");
                Console.WriteLine("\t3 - Prisma\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Kugel();
                        break;

                    case "2":
                        Console.Clear();
                        Pyramide();
                        break;

                    case "3":
                        Console.Clear();
                        Prisma();
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
            {
                Environment.Exit(0);
            }
        }



        //              Oben nichts ändern
        // ------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------
        //                                  Kugel


        public static void Kugel()
        {


            bool Exit = false;
            bool submenü = false;
            double dou_radius = 0;
            double dou_volumen = 0;
            bool parse_value = true;
            string str_radius;


            do
            {
                Console.WriteLine("Kugel");

                Console.WriteLine(" Willkommen zum Berechnen des Prisma Volumen");

                Console.WriteLine("Hier werden sie  die Volumen ihre Berechnung bekommen");



                Console.WriteLine("Bitte geben sie Radius ein");
                str_radius = Console.ReadLine();


                if (str_radius == "exit")
                    Environment.Exit(0);
                else if (str_radius == "submenü")
                    submenü = true;
                else
                {
                    parse_value = Double.TryParse(str_radius, out dou_radius);


                    if (parse_value == true)
                    {
                        dou_volumen = (4 / 3) * Math.PI * Math.Pow(dou_radius, 3);
                        // V= (4/3) * PI * (radius)^3

                        Console.WriteLine("Das Ergebnis lautet {0,10} insgesamt", dou_volumen);
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um ins Hauptmenü zu gelanden.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Fehleingabe!");
                        Console.ReadKey();
                    }
                }

                Console.Clear();
            } while (parse_value == false && submenü == false);
        }







        // -------------------------------------------------------------------------------------------------
        //                          Pyramide


        public static void Pyramide()
        {
            Console.WriteLine("Pyramide");

            bool Exit = false;
            bool submenü = false;

            double dou_höhe = 0;
            double dou_grundfläche = 0;
            double dou_volumen = 0;
            bool parse_value = true;

            string str_höhe, str_grundfläche;


            do
            {
                Console.WriteLine("Willkommen zum Berechnen des Prisma Volumen");

                Console.WriteLine("Hier werden sie  die Volumen ihre Berechnung bekommen");



                Console.WriteLine("Bitte geben sie die Höhe ein");
                str_höhe = Console.ReadLine();



                if (str_höhe == "exit")
                    Environment.Exit(0);
                else if (str_höhe == "submenü")
                    submenü = true;
                else
                {
                    parse_value = Double.TryParse(str_höhe, out dou_höhe);


                    if (parse_value == false)
                    {

                        Console.WriteLine("Fehleingabe!");
                        Console.ReadKey();

                    }

                    Console.WriteLine("Bitte geben sie die grundfläche ein ein");
                    str_grundfläche = Console.ReadLine();



                    if (str_höhe == "exit")
                        Environment.Exit(0);
                    else if (str_höhe == "submenü")
                        submenü = true;
                    else
                    {
                        parse_value = Double.TryParse(str_grundfläche, out dou_grundfläche);


                        if (parse_value == false)
                        {

                            Console.WriteLine("Fehleingabe!");
                            Console.ReadKey();

                        }
                        else
                        {
                            dou_volumen = (1.0 / 3) * dou_grundfläche * dou_höhe;

                            Console.WriteLine("Das Ergebnis lautet: {0,10}", dou_volumen);

                            // Bildschirm löschen
                            Console.WriteLine("Konsole wird gelöscht, bitte eine beliebige Taste drücken!");
                            Console.Read();
                        }
                    }

                }


                Console.Clear();
            } while (parse_value == false && submenü == false);
        }





        // -------------------------------------------------------------------------------------------------
        //                              Prisma      

        public static void Prisma()
        {
            Console.WriteLine("Prisma");

            bool Exit = false;
            bool submenü = false;

            double dou_höhe = 0;
            double dou_grundfläche = 0;
            double dou_volumen = 0;
            bool parse_value = true;

            string str_grundfläche, str_höhe;


            do
            {
                Console.WriteLine("Willkommen zum Berechnen des Prisma Volumen");

                Console.WriteLine("Hier werden sie  die Volumen ihre Berechnung bekommen");



                Console.WriteLine("Bitte geben sie die Grundfläche ein");
                str_grundfläche = Console.ReadLine();



                if (str_grundfläche == "exit")
                    Environment.Exit(0);
                else if (str_grundfläche == "submenü")
                    submenü = true;
                else
                {
                    parse_value = Double.TryParse(str_grundfläche, out dou_grundfläche);


                    if (parse_value == false)
                    {

                        Console.WriteLine("Fehleingabe!");
                        Console.ReadKey();

                    }

                    Console.WriteLine("Bitte geben sie die höhe ein ein");
                    str_höhe = Console.ReadLine();



                    if (str_höhe == "exit")
                        Environment.Exit(0);
                    else if (str_höhe == "submenü")
                        submenü = true;
                    else
                    {
                        parse_value = Double.TryParse(str_höhe, out dou_höhe);


                        if (parse_value == false)
                        {

                            Console.WriteLine("Fehleingabe!");
                            Console.ReadKey();

                        }
                        else
                        {
                            dou_volumen = dou_grundfläche * dou_höhe;

                            Console.WriteLine("Das Ergebnis lautet: {0,10}", dou_volumen);

                            // Bildschirm löschen
                            Console.WriteLine("Konsole wird gelöscht, bitte eine beliebige Taste drücken!");
                            Console.Read();
                        }

                    }

                }

                Console.Clear();
            } while (parse_value == false && submenü == false);
        }
    }
}




