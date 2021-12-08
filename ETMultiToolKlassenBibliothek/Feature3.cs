using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature3
    {
        public static void Feature3Funcion1()
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


                //Überschrift
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "             >>> Ohmsches Gesetz / Leistungsgesetz Übersicht SubSubMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung, Auswahl Oberthema
                Console.WriteLine("Wählen Sie bitte einen der folgenden Themenbereichen:\n");
                Console.WriteLine("\tO - Ohmsches Gesetz");
                Console.WriteLine("\tL - Leistungsgesetz\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();


                //Auswahl
                switch (HauptAusw)
                {

                    case "O":
                        Console.Clear();
                        OhmschesGesetz();
                        break;

                    case "L":
                        Console.Clear();
                        Leitungsgesetz();
                        break;

                    case "submenü":
                        Console.Clear();
                        Hmenue = true;   //zurück zum Submenü
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


            } while (!Exit & !Hmenue);   //Schleife

            if (Exit)
                Environment.Exit(0);
        }

        public static void OhmschesGesetz()   //1. Unterthema
        {

            Console.Clear();
            string oAuswahl;

            bool Exit = false;
            bool submenue = false;

            {
                //Bedienungsanleitung und Eingabeaufforderung
            Console.WriteLine("Ohmsches Gesetz\n");
            Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
            Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü\n");
            Console.WriteLine("Über was genau möchten Sie Informationen erhalten?\n");
            Console.WriteLine("Geben Sie bitte für Definition und Bedeutung 1, für die Formel 2 und für Anwendungsgebiete und Beispiele 3 ein.\n");
            Console.Write("Eingabe:");
            oAuswahl = Console.ReadLine();

            switch (oAuswahl)
            {

                case "1":
                    Console.Clear();

                    break;

                case "2":
                    Console.Clear();

                    break;

                case "3":
                    Console.Clear();

                    break;

                case "submenü":
                    Console.Clear();
                    submenue = true;   //zurück zum Submenü
                    break;

                case "exit":
                    Console.Clear();
                    Exit = true;
                    break;

                default:

                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadKey();

                    break;

            }


        } while (!Exit & !submenue);   //Schleife

        if (Exit)
            Environment.Exit(0);

    }

        public static void Leitungsgesetz()   //2. Unterthema
        {

            Console.Clear();
            string lAuswahl;

            bool Exit = false;
            bool submenue = false;

            {
                //Bedienungsanleitung und Eingabeaufforderung
            Console.WriteLine("Leistungsgesetz\n");
            Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
            Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü\n");
            Console.WriteLine("Über was genau möchten Sie Informationen erhalten?\n");
            Console.WriteLine("Geben Sie bitte für Definition und Bedeutung 1, für die Formel 2 und für Anwendungsgebiete und Beispiele 3 ein.\n");
            Console.Write("Eingabe:");
            lAuswahl = Console.ReadLine();

            switch (lAuswahl)
            {

                case "1":
                    Console.Clear();

                    break;

                case "2":
                    Console.Clear();

                    break;

                case "3":
                    Console.Clear();

                    break;

                case "submenü":
                    Console.Clear();
                    submenue = true;   //zurück zum Submenü
                    break;

                case "exit":
                    Console.Clear();
                    Exit = true;
                    break;

                default:

                    Console.WriteLine("Ungültige Eingabe");
                    Console.ReadKey();




                    break;

            }

                
        }   while (!Exit & !submenue);   //Schleife

        if (Exit)
            Environment.Exit(0);

    }
