using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature4
    {
        public static void Feature4Funcion1() 
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
                                  "                              >>> Elektronische Bauelemente SubSubMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü");

                //Beschreibung der Software.
                Console.WriteLine("\n\nBeschreibung Bereich \n\n");

                Hmenue = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Spule berechnen");
                Console.WriteLine("\t2 - Kondensator berechnen");
                Console.WriteLine("\t3 - Elektrischen-Widerstand berechnen\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Spule();
                        break;

                    case "2":
                        Console.Clear();
                        Kondensatorberechnen();
                        break;

                    case "3":
                        Console.Clear();
                        Widerstandbrechnen();
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
        public static void Spule()
        {
            Spulebrechnen();

        }

        public static void Spulebrechnen() 
        {
            Console.WriteLine("Induktivität der Spule\n" +
            "N = Anzahl der Windungen, L = Länge, A= Querschnittsfläche der Spule, µr = Permeabilität");
            
        }

        public static void Kondensatorberechnen() 
        {
            int auswahl;

            Console.WriteLine("Sie haben Folgende möglichkeiten zu wählen:\nLadung(1)\nKapazität(2)\nReihenschaltung(3)\nParallelschaltung(4)\nEnergieinhalt(5)\n");
            auswahl = Convert.ToInt32(Console.ReadLine());

            if (auswahl == 1)
            {
                Console.Clear();
                Console.WriteLine("Ladung des Kondensators berechnen: \n" +
                "Q = die Elektrische Ladung, " + "D = die Verschiebungsdichte, A = Feldquerschnitt bzw. Fläche der Kondensatorplatten.\n" +
                "Ihre Formel der Ladung des Kondensators lautet also: Q = D*A");
                Console.WriteLine("\n");
            }


            else if (auswahl == 2)
            {
                Console.Clear();
                Console.WriteLine("Kapazität des Kondensators:\n" +
                "C = Kapazität des Kondensators, Q = elektrische Ladung, U = Spannung\n" +
                "Ihre Formel der Kapazität des Kondensators lautet also C = Q/U");
                Console.WriteLine("\n");
            }

            else if(auswahl == 3)
            {
                Console.Clear();
                Console.WriteLine("Reihenschaltungen von Kondensatoren:\n" +
                "Cges = Die ersatz Kapazität, die Gesamt Zusammensätzung von 1/C1, 1/C2, 1/C3 (und weiter falls mehrere ersatzkapazitäten gegeben sind!)\n" +
                "Bedeutet die Formel lautet: Cges = 1/Cges = 1/C1 + 1/C2 + 1/C3 (...)");
                Console.WriteLine("\n");
            }

            else if(auswahl == 4)
            {
                Console.Clear();
                Console.WriteLine("Parallelschaltung von Kondensatoren:\n" +
                "Erneut Cges = Die ersatz Kapazität, die Gesamt Zusammensätzung aus C1, C2, C3 (und weiter falls mehrere ersatzkapazitäten gegeben sind!)\n" +
                "Diesmal heißt es also für die Formel: Cges = C1 + C2 + C3 (...)");
                Console.WriteLine("\n)");
            }

            else if (auswahl == 5)
            {
                Console.Clear();
                Console.WriteLine("Energieinalt des Kondensators:\n" +
                "Welektr. = Energieinhalt von Kondensatoren, C = Kapazität eines Kondensators, U = Urspannung\n" +
                "Formel heißt: Welektr= 1/2*C*U^2");
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine("Fehler");
            }


        }

        public static void Widerstandbrechnen() 
        {
            int auswahl;

            Console.Clear();
            Console.WriteLine("Sie haben Folgende möglichkeiten zu wählen:\nWiderstand und Leitwert(1)\n" +
            "Einheitswiderstand und Einheitsleitwert(2)\nLeiterwiderstand(3)\nReihenschaltung von Widerständen(4)\nParallelschaltungen von Widerständen\n");
            auswahl = Convert.ToInt32(Console.ReadLine());


            if (auswahl == 1)
            {
                Console.Clear();
                Console.WriteLine("Widerstand und Leitwert\n" +
                "R = Widerstand, G = Leitwert\n" +
                "Formel für den Widerstand: G= 1/R\n" +
                "Formel für den Leitwert: R= 1/G");
            }

            else if (auswahl == 2)
            {
                Console.Clear();
                Console.WriteLine("Einheitswiderstand und Einheitsleitwert\n" +
                "P = Einheitswiderstand, hierbei kommts drauf an welchen Leiter wir haben.\n" +
                "Beispielsleiter und ihre Werte: Silber = 0,016, Kupfer = 0,1786, Alluminium = 0,02857\n" +
                "Das selbe jetzt mit K, K = Einheitsleitwert erneute Beispielsleiter und ihre Werte:\n" +
                "Silber = 62,5, Kupfer = 56, Alluminium = 35\n" +
                "Sprich Formel für den Einheitswiderstand: P = 1/K\n" +
                "Formel für den Einheitsleitwert: K = 1/P");
            }

            else if (auswahl == 3)
            {
                Console.Clear();
                Console.WriteLine("Leiterwiderstand\n" +
                "R = der Leiterwiderstand, L = die Länge des Drahtes, A = der Querschnitt des Drahtes, K = Einheitsleitwert, P = Einheitswiderstand\n" +
                "Formel für den Leiterwiderstand mit dem Einheitswiderstand: R = P*L/A\n" +
                "Formel für den Leiterwiderstand mit dem Einheitsleitwert: R = L/K*A");
            }


            else if (auswahl == 4)
            {
                Console.Clear();
                Console.WriteLine("Reihenschaltungen von Widerständen\n" +
                "Rges = Gesamtwiderstand = Der Gesamtteil von Teilwiderständen wie z.B. R1 + R2 + R3(wenn mehrere Teilwiderstände zur verfügung stehen erweitern!)\n" +
                "Iges = Gesamtstrom stärke = Der Gesamtteil vom Strom zusammengesätzt wie z.B. I1 + I2 + I3(Hier ebenfalls, wenn mehrere Stromstärken zur verfügung stehen erweitern!)\n" +
                "Uges = Gesamtspannung = Der Gesamtteil von der Spannung wie z.B. U1 + U2+ U3(ebenfalls, wenn mehrere Teilspannungen zur verfügung stehen erweitern!)\n" +
                "Formel für den Gesamtwiderstand: Rges = R1 + R2 + R3(...)\n" +
                "Formel für die Gesamtstrom stärke: Iges = I1 + I2 + I3(...)\n" +
                "Formel für die Gesamtspannung: Uges = U1 + U2 + U3(...)");
            }


            else if (auswahl == 5)
            {
                Console.Clear();
                Console.WriteLine("Parallelschaltugen von Widerständen\n" +
                "Hier gilt das selbe wie bei der Reihenschaltung:\n" +
                "1/Rges = Gesamtwiderstand = Der Gesamtteil von Teilwiderständen wie z.B. 1/R1 + 1/R2 + 1/R3(wenn mehrere Teilwiderstände zur verfügung stehen erweitern!)\n" +
                "1/Iges = Gesamtstrom stärke = Der Gesamtteil vom Strom zusammengesätzt wie z.B. 1/I1 + 1/I2 + 1/I3(Hier ebenfalls, wenn mehrere Stromstärken zur verfügung stehen erweitern!)\n" +
                "1/Uges = Gesamtspannung = Der Gesamtteil von der Spannung wie z.B. 1/U1 + 1/U2 + 1/U3(ebenfalls, wenn mehrere Teilspannungen zur verfügung stehen erweitern!)\n" +
                "Formel für den Gesamtwiderstand: 1/Rges = 1/R1 + 1/R2 + 1/R3(...)\n" +
                "Formel für die Gesamtstrom stärke: 1/Iges = 1/I1 + 1/I2 + 1/I3(...)\n" +
                "Formel für die Gesamtspannung: 1/Uges = 1/U1 + 1/U2 + 1/U3(...)");
            }






        }

        
    }
}
