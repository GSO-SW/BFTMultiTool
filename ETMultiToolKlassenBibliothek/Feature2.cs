using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature2
    {
        #region SubMenu
        public static void Feature2Funcion1()
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
                                  "                              >>> Strom Aufbau SubSubMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBerechnung des Spannungsfalls und des Leitungsquerschnittes \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Spannungsfall berechnen");
                Console.WriteLine("\t2 - Leitungsquerschnitt berechnen\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Spannungsfallberechnen();
                        break;

                    case "2":
                        Console.Clear();
                        Leitungsquerschnittberechnen();
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


        #region Spannungsfall
        public static void Spannungsfallberechnen()
        {
            Console.Clear();
            double leitfähigkeit = 0, volt = 0, strom = 0, länge = 0, querschnitt = 0; string material = null;
            bool retry = false, restart = false;
            {


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                 "                              >>> Berechnung Spannungsfall <<<\n" +
                                 "------------------------------------------------------------------------------------\n\n");


                do
                {

                    do
                    {
                        Console.WriteLine("Bitte wählen sie nun das Material \n(1) Kupfer \n(2) Gold \n(3) Aluminium \n(4) Silber \n(4) Zink \n(5) Nickel \n(6) Platin \n(7) Zinn \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                        string m_auswahl = (Console.ReadLine());
                        switch (m_auswahl)
                        {
                            case "1":
                                leitfähigkeit = 56; material = "Kupfer";
                                break;

                            case "2":
                                leitfähigkeit = 45.45; material = "Gold";
                                break;

                            case "3":
                                leitfähigkeit = 36; material = "Aluminium";
                                break;

                            case "4":
                                leitfähigkeit = 16; material = "Silber";
                                break;

                            case "5":
                                leitfähigkeit = 16; material = "Zink";
                                break;

                            case "6":
                                leitfähigkeit = 10.5; material = "Nickel";
                                break;

                            case "7":
                                leitfähigkeit = 10.2; material = "Platin";
                                break;

                            case "8":
                                leitfähigkeit = 8.7; material = "Zinn";
                                break;

                            case "0":
                                Console.WriteLine("Geben sie bitte die Leitfähigkeit des Material in Siemens pro Meter bei 20°C an");
                                leitfähigkeit = Convert.ToDouble(Console.ReadLine());
                                break;

                            case "exit":

                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }
                    } while (retry == true);
                    retry = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Bitte wählen sie den Strom in Ampere aus! \n(1) 2 A \n(2) 4 A \n(3) 10 A \n(4) 13 A \n(5) 16 A \n(6) 20 A \n(7) 25 A \n(8) 32 A \n(9)35 A \n(10) 50 \n(11) 63 A \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                        string s_auswahl = ((Console.ReadLine()));
                        switch (s_auswahl)
                        {
                            case "1":
                                strom = 2;
                                break;

                            case "2":
                                strom = 4;
                                break;

                            case "3":
                                strom = 10;
                                break;

                            case "4":
                                strom = 13;
                                break;

                            case "5":
                                strom = 16;
                                break;

                            case "6":
                                strom = 20;
                                break;

                            case "7":
                                strom = 25;
                                break;

                            case "8":
                                strom = 32;
                                break;

                            case "9":
                                strom = 35;
                                break;

                            case "10":
                                strom = 50;
                                break;

                            case "11":
                                strom = 63;
                                break;

                            case "0":
                                strom = Convert.ToDouble(Console.ReadLine());
                                break;

                            case "exit":
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }
                    } while (retry == true);
                    retry = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Bitte wählen sie die Spannung in Volt aus! \n(1) 12 V \n(2) 24 V \n(3) 115 V \n(4) 230 V \n(5) 400 V \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                        string v_auswahl = ((Console.ReadLine()));
                        switch (v_auswahl)
                        {
                            case "1":
                                volt = 12;
                                break;

                            case "2":
                                volt = 24;
                                break;

                            case "3":
                                volt = 115;
                                break;

                            case "4":
                                volt = 230;
                                break;

                            case "5":
                                volt = 400;
                                break;

                            case "0":
                                volt = Convert.ToDouble(Console.ReadLine());
                                break;

                            case "exit":
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }
                    } while (retry == true);
                    retry = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Bitte wählen sie die Länge in Meter aus! \n(1) 25m \n(2) 50m \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                        string l_auswahl = ((Console.ReadLine()));
                        switch (l_auswahl)
                        {
                            case "1":
                                länge = 25;
                                break;

                            case "2":
                                länge = 50;
                                break;

                            case "0":
                                länge = Convert.ToDouble(Console.ReadLine());
                                break;

                            case "exit":
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }
                    } while (retry == true);
                    retry = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Bitte wählen sie den Kabel Querschnitt in mm² aus! \n(1) 0.75 mm² \n(2) 1 mm² \n(3) 1.5 mm² \n(4) 2.5 mm² \n(5) 4 mm² \n(6) 6 mm² \n(7) 10 mm² \n(8) 16 mm² \n(9) 25 mm² \n(10) 35 mm² \n(11) 50 mm² \n(12) 70 mm² \n(13) 90 mm² \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                        string q_auswahl = ((Console.ReadLine()));
                        switch (q_auswahl)
                        {
                            case "1":
                                querschnitt = 0.75;
                                break;

                            case "2":
                                querschnitt = 1;
                                break;

                            case "3":
                                querschnitt = 1.5;
                                break;

                            case "4":
                                querschnitt = 2.5;
                                break;

                            case "5":
                                querschnitt = 4;
                                break;

                            case "6":
                                querschnitt = 6;
                                break;

                            case "7":
                                querschnitt = 10;
                                break;

                            case "8":
                                querschnitt = 16;
                                break;

                            case "9":
                                querschnitt = 25;
                                break;

                            case "10":
                                querschnitt = 35;
                                break;

                            case "11":
                                querschnitt = 50;
                                break;

                            case "12":
                                querschnitt = 70;
                                break;

                            case "13":
                                querschnitt = 90;
                                break;

                            case "0":
                                querschnitt = Convert.ToDouble(Console.ReadLine());
                                break;

                            case "exit":
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }
                    } while (retry == true);
                    retry = false;
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Sie haben ausgewählt: \n {0} mit einer Leitfähigkeit von {1} S/m \n Stromstärke: {2} Ampere \n Spannung : {3} Volt \n Länge : {4} Meter \n Kabel Querschnitt : {5} mm² \n Sind sie mit diesen Eingaben zu frieden? \n (1) Ja (2) Nein \n\n Tippen sie exit um das Programm zu beenden", material, leitfähigkeit, strom, volt, länge, querschnitt);
                        string auswahl = (Console.ReadLine());
                        switch (auswahl)
                        {
                            case "1":

                                break;

                            case "2":
                                restart = true;
                                break;

                            case "exit":
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                                retry = true;
                                Console.Read();
                                break;
                        }

                    } while (retry == true);
                    retry = false;
                    Console.Clear();
                } while (restart == true);
                restart = false;


                double spannungsfall = (länge / (leitfähigkeit * querschnitt)) * strom;

                Console.WriteLine("Der Spannungsabfall beträgt {0:N2} Volt oder auch {1:N2} % und bei ihnen kommen somit {2:N2} Volt an \n(Der Spannungsfall kann sich leicht ändern bei anderen Temperaturen als 20°C)", spannungsfall, spannungsfall / (volt / 100), volt - spannungsfall);
                Console.ReadKey();
            }
        }
        #endregion

        #region Leitungsquerschnitt

        public static void Leitungsquerschnittberechnen()
        {
            Console.Clear();
            double leitfähigkeit = 0, volt = 0, strom = 0, länge = 0, spannungsfall = 0; string material = "";
            bool retry = false, restart = false;



            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                             "                              >>> Berechnung Leitungsquerschnitt <<<\n" +
                             "------------------------------------------------------------------------------------\n\n");



            do
            {

                do
                {
                    Console.WriteLine("Bitte wählen sie nun das Material \n(1) Kupfer \n(2) Gold \n(3) Aluminium \n (4) Silber \n (4) Zink \n (5) Nickel \n (6) Platin \n (7) Zinn \n (0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                    string m_auswahl = ((Console.ReadLine()));
                    switch (m_auswahl)
                    {
                        case "1":
                            leitfähigkeit = 56; material = "Kupfer";
                            break;

                        case "2":
                            leitfähigkeit = 45.45; material = "Gold";
                            break;

                        case "3":
                            leitfähigkeit = 36; material = "Aluminium";
                            break;

                        case "4":
                            leitfähigkeit = 16; material = "Silber";
                            break;

                        case "5":
                            leitfähigkeit = 16; material = "Zink";
                            break;

                        case "6":
                            leitfähigkeit = 10.5; material = "Nickel";
                            break;

                        case "7":
                            leitfähigkeit = 10.2; material = "Platin";
                            break;

                        case "8":
                            leitfähigkeit = 8.7; material = "Zinn";
                            break;

                        case "0":
                            Console.WriteLine("Geben sie bitte die Leitfähigkeit des Material in Siemens pro Meter bei 20°C an");
                            leitfähigkeit = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                            retry = true;
                            Console.Read();
                            break;
                    }
                } while (retry == true);
                retry = false;
                Console.Clear();

                do
                {
                    Console.WriteLine("Bitte wählen sie den Strom in Amper aus! \n(1) 2 A \n(2) 4 A \n(3) 10 A \n(4) 13 A \n(5) 16 A \n(6) 20 A \n(7) 25 A \n(8) 32 A \n(9)35 A \n(10) 50 \n(11) 63 A \n(0) Anderes");
                    string s_auswahl = ((Console.ReadLine()));
                    switch (s_auswahl)
                    {
                        case "1":
                            strom = 2;
                            break;

                        case "2":
                            strom = 4;
                            break;

                        case "3":
                            strom = 10;
                            break;

                        case "4":
                            strom = 13;
                            break;

                        case "5":
                            strom = 16;
                            break;

                        case "6":
                            strom = 20;
                            break;

                        case "7":
                            strom = 25;
                            break;

                        case "8":
                            strom = 32;
                            break;

                        case "9":
                            strom = 35;
                            break;

                        case "10":
                            strom = 50;
                            break;

                        case "11":
                            strom = 63;
                            break;

                        case "0":
                            strom = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                } while (retry == true);
                retry = false;
                Console.Clear();

                do
                {
                    Console.WriteLine("Bitte wählen sie die Spannung in Volt aus! \n(1) 12 V \n(2) 24 V \n(3) 115 V \n(4) 230 V \n(5) 400 V \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                    string v_auswahl = ((Console.ReadLine()));
                    switch (v_auswahl)
                    {
                        case "1":
                            volt = 12;
                            break;

                        case "2":
                            volt = 24;
                            break;

                        case "3":
                            volt = 115;
                            break;

                        case "4":
                            volt = 230;
                            break;

                        case "5":
                            volt = 400;
                            break;

                        case "0":
                            volt = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                } while (retry == true);
                retry = false;
                Console.Clear();

                do
                {
                    Console.WriteLine("Bitte wählen sie die Länge in Meter aus! \n(1) 25m \n(2) 50m \n(0) Anderes \n\n Tippen sie exit um das Programm zu beenden");
                    string l_auswahl = ((Console.ReadLine()));
                    switch (l_auswahl)
                    {
                        case "1":
                            länge = 25;
                            break;

                        case "2":
                            länge = 50;
                            break;

                        case "0":
                            länge = Convert.ToDouble(Console.ReadLine());
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                } while (retry == true);
                retry = false;
                Console.Clear();

                do
                {
                    Console.WriteLine("Bitte geben sie den Spannungsfall in Volt ein!");
                    spannungsfall = Convert.ToDouble((Console.ReadLine()));
                } while (retry == true);
                retry = false;
                Console.Clear();

                do
                {
                    Console.WriteLine("Sie haben ausgewählt: \n {0} mit einer Leitfähigkeit von {1} S/m \n Stromstärke: {2} Ampere \n Spannung : {3} Volt \n Länge : {4} Meter \n Spannungsfall : {5} V \n Sind sie mit diesen Eingaben zu frieden? \n (1) Ja (2) Nein \n\n Tippen sie exit um das Programm zu beenden", material, leitfähigkeit, strom, volt, länge, spannungsfall);
                    string auswahl = (Console.ReadLine());
                    switch (auswahl)
                    {
                        case "1":

                            break;

                        case "2":
                            restart = true;
                            break;

                        case "exit":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Fehlerhafte Eingabe! versuchen sie es bitte erneut!");
                            retry = true;
                            Console.Read();
                            break;
                    }
                } while (retry == true);
                retry = false;
                Console.Clear();

            } while (restart == true);
            restart = false;


            double leitungsquerschnitt = (2 * länge * strom) / (leitfähigkeit * spannungsfall) * 10;

            Console.WriteLine("Der Kabelquerschnitt beträgt {0:N2} mm²", leitungsquerschnitt);
        }

        #endregion



    }
}