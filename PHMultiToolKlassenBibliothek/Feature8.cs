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
                Environment.Exit(0);
        }



        //              Oben nichts ändern
        // ------------------------------------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------------------------
        //                                  Kugel


        public static void Kugel()
        {
            Console.WriteLine("Kugel");

            double dou_radius = 0;
            double dou_volumen = 0;
            bool parse_value;

            string str_radius;

            do
            {
                do
                {
                    Console.WriteLine("Bitte geben sie Radius ein");
                    str_radius = Console.ReadLine();

                    parse_value = Double.TryParse(str_radius, out dou_radius);
                } while (parse_value == false);



                dou_volumen = (4 / 3) * Math.PI * Math.Pow(dou_radius, 3);
                // V= (4/3) * PI * (radius)^3

                Console.WriteLine("Das Ergebnis lautet {0,10} insgesamt", dou_volumen);

            } while (true);
        }






        // -------------------------------------------------------------------------------------------------
        //                          Pyramide


        public static void Pyramide()
        {
            Console.WriteLine("Pyramide");

            double dou_höhe = 0;
            double dou_grundfläche = 0;
            double dou_volumen = 0;

            string str_höhe, str_grundfläche;
            bool parse_value;

            do
            {
                do
                {
                    Console.WriteLine("Bitte geben sie die Höhe ein");
                    str_höhe = Console.ReadLine();

                    parse_value = Double.TryParse(str_höhe, out dou_höhe);
                } while (parse_value == false);





                do
                {
                    Console.WriteLine("Bitte geben sie die Grundfläche ein");
                    str_grundfläche = Console.ReadLine();
                    parse_value = Double.TryParse(str_grundfläche, out dou_grundfläche);
                }
                while (parse_value == false);

                dou_volumen = (1.0 / 3) * dou_grundfläche * dou_höhe;

                Console.WriteLine("Das Ergebnis lautet: {0,10}", dou_volumen);

                // Bildschirm löschen
                Console.WriteLine("Konsole wird geloescht !");
                Console.Read();
                Console.Clear();
            } while (true);
        }




        // -------------------------------------------------------------------------------------------------
        //                              Prisma      


        public static void Prisma()
        {
            Console.WriteLine("Prisma");

            double dou_höhe = 0;
            double dou_grundfläche = 0;
            double dou_volumen = 0;

            string str_höhe, str_grundfläche;
            bool parse_value;

            do
            {
                do
                {
                    Console.WriteLine("Bitte geben sie die Grundfläche ein");    //Eingabe der Grundfläche erforderlich 
                    str_grundfläche = Console.ReadLine();

                    parse_value = Double.TryParse(str_grundfläche, out dou_grundfläche);
                } while (parse_value == false);





                do
                {
                    Console.WriteLine("Bitte geben sie die Höhe ein");
                    str_höhe = Console.ReadLine();
                    parse_value = Double.TryParse(str_höhe, out dou_höhe);
                }
                while (parse_value == false);

                dou_volumen = dou_grundfläche * dou_höhe;

                Console.WriteLine("Das Ergebnis lautet: {0,10}", dou_volumen);

                // Bildschirm löschen
                Console.WriteLine("Konsole wird geloescht !");
                Console.Read();
                Console.Clear();
            } while (true);
        }
    }
}




