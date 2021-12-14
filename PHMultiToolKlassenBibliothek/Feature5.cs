





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
                Console.WriteLine("\t3 - Minuten in Stunden");
                Console.WriteLine("\t4 - Ampere und Volt in Watt");
                Console.WriteLine("\t5 - Kelvin in Grad\n");
                Console.Write("Eingabe:");

                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        SiEinheit.Kilometer();
                        break;

                    case "2":
                        Console.Clear();
                        SiEinheit.Kilogramm();
                        break;

                    case "3":
                        Console.Clear();
                        SiEinheit.Stunden();
                        break;

                    case "4":
                        Console.Clear();
                        SiEinheit.Watt();
                        break;

                    case "5":
                        Console.Clear();
                        SiEinheit.Kelvin();
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
                Console.WriteLine("\t1 - mm in cm");
                Console.WriteLine("\t2 - cm in dm");
                Console.WriteLine("\t3 - cm in m");
                Console.WriteLine("\t4 - m in km");

                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        SiEinheit.milimeter();
                        break;

                    case "2":
                        Console.Clear();
                        SiEinheit.dcentimeter();
                        break;

                    case "3":
                        Console.Clear();
                        SiEinheit.mcentimeter();
                        break;

                    case "4":
                        Console.Clear();
                        SiEinheit.meter();
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
        public static void Kilometer()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Meter in Kilometer <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Meter ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Volt Meter an:");
                string str_Eingabe = Console.ReadLine();

                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);


                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 1000;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Meter diviert durch 1000. Ein Beispiel für Sie: 100 Meter / 1000 = 0,1 Kilometer.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Meter: {doub_Eingabe} einen Kilometerstand von: {Kilometer} Kilometer.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void Kilogramm()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung  in Kilogramm <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Gramm ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Volt Gramm an:");
                string str_Eingabe = Console.ReadLine();

                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);


                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");   
                        double Kilometer = doub_Eingabe / 1000;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Gramm diviert durch 1000. Ein Beispiel für Sie: 100 Gramm / 1000 = 0,1 Kilogramm.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Meter: {doub_Eingabe} einen Kilogrammstand von: {Kilometer} Kilogramm.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void Stunden()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Minuten in Stunden <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Minuten ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Volt Minuten an:");
                string str_Eingabe = Console.ReadLine();

                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);


                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 60;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Minuten diviert durch 60. Ein Beispiel für Sie: 60 min / 60 = 1 Stunde.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Minuten: {doub_Eingabe} einen Stundenstand von: {Kilometer} Stunden.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void Watt()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Volt und Ampere in Watt <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Ampere und Volt ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Volt Angaben an:");
                string str_Eingabe = Console.ReadLine();
                Console.WriteLine("Nun geben Sie Ihre Ampere Angaben ein:");
                string Ampere = Console.ReadLine();


                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);
                    double doub_Ampere = Convert.ToDouble(Ampere);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe * doub_Ampere;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Volt mal Ampere. Ein Beispiel für Sie: 20 Volt * 10 Ampere = 200 Watt, kurz 200 W.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Volt: {doub_Eingabe} und Ampere: {doub_Ampere} einen Wattstand von: {Kilometer} Watt.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void Kelvin()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Kelvin in Grad <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit Kelvin ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Kelvin an:");
                string str_Eingabe = Console.ReadLine();
                


                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe - 273.15;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Kelvin - 273.15. Ein Beispiel für Sie: 300 Kelvin - 273.15 = 26.25 Grad.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Kelvin: {doub_Eingabe} einen Gradstand von: {Kilometer} Grad.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void milimeter()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Milimeter in Centimeter <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Milimeter ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Militmeter an:");
                string str_Eingabe = Console.ReadLine();



                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 10;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Milimeter dividiert durch 10. Ein Beispiel für Sie: 1mm / 10 = 0,1cm.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Milimeter: {doub_Eingabe} einen Centimeterstand von: {Kilometer} cm.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true); // dcentimeter
        }
        public static void dcentimeter()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Centimeter in Dezimeter <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Centimeter ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Centimeter an:");
                string str_Eingabe = Console.ReadLine();



                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 10;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Centimeter dividiert durch 10. Ein Beispiel für Sie: 1cm / 10 = 0,1dm.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Centimeter: {doub_Eingabe} einen Dezimeterstand von: {Kilometer} dm.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true); 
        }
        public static void mcentimeter()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Centimeter in Meter <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Centimeter ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Centimeter an:");
                string str_Eingabe = Console.ReadLine();



                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 100;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Meter dividiert durch 100. Ein Beispiel für Sie: 1cm / 100 = 0,01m.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Centimeter: {doub_Eingabe} einen Meterstand von: {Kilometer} m.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
        public static void meter()
        {
            bool Subexit = false;
            bool Errorcode = false;
            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Umrechnung Meter in Kilometer <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Willkommen zum Bereich `Umrechnung von Maßeinheiten`. Hier kann man ganz einfach seine Einheiten umrechnen.\n" +
                    "Ganz ohne große Kopfrechnungen oder googlen zu müssen. Wählen Sie ihren gewünschten Bereich und wir rechnen dies für Sie.\n\n" +
                    "Geben Sie nun ihre Einheit in Meter ein. Andernfalls kannst du `Subexit` eingeben und Sie gelangen sofort zum Physik Menü.\n\n");
                Console.WriteLine("Geben Sie nun Ihre Meter an:");
                string str_Eingabe = Console.ReadLine();



                if (str_Eingabe == "Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    double doub_Eingabe = Convert.ToDouble(str_Eingabe);

                    Errorcode = false;
                    if (doub_Eingabe >= 0)
                    {
                        Console.WriteLine("Berechnung:\n\n");
                        double Kilometer = doub_Eingabe / 1000;
                        Console.WriteLine("Wir rechnen ihre eingegebenen Meter dividiert durch 1000. Ein Beispiel für Sie: 1m / 1000 = 0,001m.");
                        Console.WriteLine($"Somit ergibt sich bei Ihren angegebenen Meter: {doub_Eingabe} einen Kilometerstand von: {Kilometer} km.\n");
                        Console.WriteLine("Wenn Sie fertig sind, drücken Sie eine beliebige Taste, um zurückzukehren.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein");
                        Console.ReadKey();
                    }


                }


                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }
    }
}
