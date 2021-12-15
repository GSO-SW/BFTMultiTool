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
            bool Submenü;

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
                                  "                        >>> Elektronische Bauelemente SubSubMenü <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                //Beschreibung der Software.
                Console.WriteLine("\n\nWillkommen im Elektrischen-Bauelemente-Menü!\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü\n\n");

                Submenü = false;

                //Eingabeaufforderung 
                Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
                Console.WriteLine("\t1 - Spule");
                Console.WriteLine("\t2 - Kondensator ");
                Console.WriteLine("\t3 - Elektrischen-Widerstand\n");
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
                        Kondensator();
                        break;

                    case "3":
                        Console.Clear();
                        Widerstand();
                        break;

                    case "submenü":
                        Console.Clear();
                        Submenü = true;
                        break;

                    case "exit":
                        Exit = true;
                        break;

                    default:

                        Console.WriteLine("Fehleingabe!");
                        Console.ReadKey();

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Submenü);

            if (Exit)
                Environment.Exit(0);
        
        }


        public static void Spule()
        {
            string intro = "Spulenmenü";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {

                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Sie haben insgesamt 3 Auswahlen zur Verfügung.\n" +
                "Für die Formel, geben Sie bitte (1) ein.\n" +
                "Für den Nutze der Spule, bitte (2) eingeben.\n" +
                "Für die Definition der Spule, bitte (3) eingeben.\n");

                string auswahlspule = Convert.ToString(Console.ReadLine());

                switch (auswahlspule)
                {
                    case "1":
                        Console.Clear();
                        Spuleformel();
                        break;

                    case "2":
                        Console.Clear();
                        Spulenutze();
                        break;

                    case "3":
                        Console.Clear();
                        Spuledefinition();
                        break;

                    case "submenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Fehlereingabe!");
                        break;

                }

            }
            while (!exit & !subsubmenü);

            if (exit)
            {
                Environment.Exit(0);
            }
        }

        static void Spuleformel()
        {
            string intro = "Spulenformel";
            Console.WriteLine(intro.ToUpper());
            bool subsubmenü = false;
            bool exit = false;

            do
            {

                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Sie haben folgende möglichkeiten:\n" +
                "" + "Induktivität Spule(1)\n" +
                "" + "Reihenschaltung Spule(2)\n" +
                "" + "Parallelschaltung Spule(3)\n" +
                "" + "Energieinhalt des magnetischen Feldes Spule(4)\n");


                string auswahl = Convert.ToString(Console.ReadLine());

                switch (auswahl)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Induktivität der Spule\n" +
                    "N = Anzahl der Windungen, l = Länge, A= Querschnittsfläche der Spule, µr = Permeabilität" +
                    "(µr steht in diesem Fall für relative Permeabilität, µo = Magnetische Feldkonstante, L = die Induktivität\n" +
                    "Die Formel normal-Formel lautet: L = N^2*µo*µr*A/l");
                        break;

                    case "2":

                        Console.Clear();
                        Console.WriteLine("Reihenschaltung der Spule\n" +
                        "Lges = Wird zusammengesetzt aus den Ersatzinduktivitäten der Spule. => z.B L1 + L2 + L3" +
                        "(Wenn mehrere induktivitäten möglich sind, diese ebenfalls einbeziehen!)\n" +
                        "Formel: Lges = L1 + L2 + L3(...)");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Parallelschaltung der Spule\n" +
                    "1/Lges = Wird erneut von den Ersatzinduktivitäten der Spule zusammengesetzt. => z.B 1/L1 + 1/L2 + 1/L3" +
                    "(Hier auch wieder bei mehreren induktivitäten diese auch einbeziehen!)\n" +
                    "FOrmel: 1/Lges = 1/L1 + 1/L2 + 1/L3(...)");
                        Console.WriteLine("\n");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Energieinhalt des magnetischen Feldes einer Spule\n" + //Vierte Ausgabe
                        "Wmagn = Die Energie, L = Induktivität der Spule, I = Stromstärke\n" +
                        "Die Formel lautet: Wmagn = 1/2*L*I^2");
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fehlereingabe!");
                        break;

                }
            }while (!exit & !subsubmenü);

                if (exit)
            
                Environment.Exit(0);
        }  


        static void Spulenutze()
        {
            string intro = "nutze der Spule";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;



            do
            {

                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Eine Spule ist ein elektrisches Bauelement, bei dem ein langer dünner Leiter spiralförmig um einen meist zylindrischen Körper gewickelt wird.\n" +
                "Spulen werden in vielen Bereichen eingesetzt, u. a. sind sie die Grundbausteine von Elektromagneten und Elektromotoren.\n" +
                "Jeder fließende elektrische Strom induziert um den Leiter ein Magnetfeld.Bei einer kreisförmigen Leiterschlaufe verläuft das senkrecht durch die Kreismitte,\n" +
                "daher ergibt sich bei den vielen hintereinanderliegenden Schlaufen einer Spule in deren Innerem ein annähernd homogenes Magnetfeld in Längsrichtung der Spule.");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch(auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            }while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);
            

        }

        static void Spuledefinition()
        {
            string intro = "Spuledefinition";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {
                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("n der Elektrotechnik sind Spulen wichtige Bestandteile elektrischer Baugruppen oder Geräte. Spulen fallen unter die sogenannten passiven elektrischen Bauelemente.\n" +
                "Sie werden oft auch als Induktivitäten oder Drosseln bezeichnet. Eine Spule ist ein Leiter(Draht, meist Kupferlackdraht oder Hochfrequenzlitze),\n" +
                "der zu einer oder mehreren Windungen geformt ist. Die Windungsanordnung, ihr Durchmesser und das Kernmaterial legen die Induktivität und weitere Eigenschaften der Spule fest.");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch (auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            } while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);

        }

        static void Kondensator()
        {
            string intro = "Kondensatormenü";
            Console.WriteLine(intro.ToUpper());
            Console.WriteLine("\n");
            bool exit = false;
            bool subsubmenü = false;

            do
            {
                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Sie haben insgesamt 4 Auswahlen zur Verfügung.\n" +
                "Für die Formel, geben Sie bitte (1) ein.\n" +
                "Für den Nutze des Kondensators, bitte (2) eingeben.\n" +
                "Für die Definition des Kondensators, bitte (3) eingeben.\n");
                string auswahlmöglichkeiten = Convert.ToString(Console.ReadLine());

                switch (auswahlmöglichkeiten)
                {
                    case "1":
                        Console.Clear();
                        KondensatorFormel();
                        break;

                    case "2":
                        Console.Clear();
                        Kondensatornutze();
                        break;

                    case "3":
                        Console.Clear();
                        Kondensatordefinition();
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Fehlermeldung!");
                        break;
                }

            } while (!exit & !subsubmenü);

                if (exit)
                    Environment.Exit(0);
        }

        static void KondensatorFormel()
        {
            string auswahl;
            string Intro = "Kondensator Menü";
            Console.WriteLine(Intro.ToUpper());
            bool subsubmenü = false;
            bool exit = false;

            do
            {
                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");


                Console.WriteLine("Sie haben Folgende möglichkeiten zu wählen:\nLadung(1)" +
                "\nKapazität(2)\n" +
                "Reihenschaltung(3)\n" +
                "Parallelschaltung(4)\n" +
                "Energieinhalt(5)\n");
                auswahl = Convert.ToString(Console.ReadLine());

                switch (auswahl)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ladung des Kondensators berechnen: \n" +
                            "Q = die Elektrische Ladung, " + "D = die Verschiebungsdichte, A = Feldquerschnitt bzw. Fläche der Kondensatorplatten.\n" +
                            "Ihre Formel der Ladung des Kondensators lautet also: Q = D*A");
                        Console.WriteLine("\n");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Kapazität des Kondensators:\n" +
                            "C = Kapazität des Kondensators, Q = elektrische Ladung, U = Spannung\n" +
                            "Ihre Formel der Kapazität des Kondensators lautet also C = Q/U");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Reihenschaltungen von Kondensatoren:\n" +
                            "Cges = Die ersatz Kapazität, die Gesamt Zusammensätzung von 1/C1, 1/C2, 1/C3 (und weiter falls mehrere ersatzkapazitäten gegeben sind!)\n" +
                            "Bedeutet die Formel lautet: Cges = 1/Cges = 1/C1 + 1/C2 + 1/C3 (...)");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Parallelschaltung von Kondensatoren:\n" +
                            "Erneut Cges = Die ersatz Kapazität, die Gesamt Zusammensätzung aus C1, C2, C3 (und weiter falls mehrere ersatzkapazitäten gegeben sind!)\n" +
                            "Diesmal heißt es also für die Formel: Cges = C1 + C2 + C3 (...)");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Energieinalt des Kondensators:\n" +  //Fünfte Ausgabe
                        "Welektr. = Energieinhalt von Kondensatoren, C = Kapazität eines Kondensators, U = Urspannung\n" +
                        "Formel heißt: Welektr= 1/2*C*U^2");
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fehlermeldung");
                        break;

                }
            } while (!exit & !subsubmenü);

                    if (exit)
                        Environment.Exit(0);
        }

        static void Kondensatornutze()
        {
            string intro = "nutze des Kondensators";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {

                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Ein Kondensator (von lateinisch condensare ‚verdichten‘) ist ein passives elektrisches Bauelement mit der Fähigkeit,\n" +
                "in einem Gleichstromkreis elektrische Ladung und die damit zusammenhängende Energie statisch in einem elektrischen Feld zu speichern.\n" +
                " Die gespeicherte Ladung pro Spannung wird als elektrische Kapazität bezeichnet und in der Einheit Farad gemessen.\n" +
                "In einem Wechselstromkreis wirkt ein Kondensator als Wechselstromwiderstand mit einem frequenzabhängigen Impedanzwert.");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch (auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            } while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);
        }

        static void Kondensatordefinition()
        {
            string intro = "Definition des Kondensators";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {


                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Ein Kondensator ist ein passives elektrisches Bauelement mit der Fähigkeit,\n" +
                "in einem Gleichstromkreis elektrische Ladung und die damit zusammenhängende Energie statisch in einem elektrischen Feld zu speichern.\n" +
                " Die gespeicherte Ladung pro Spannung wird als elektrische Kapazität bezeichnet und in der Einheit Farad gemessen.\n" +
                "In einem Wechselstromkreis wirkt ein Kondensator als Wechselstromwiderstand mit einem frequenzabhängigen Impedanzwert");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch (auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            } while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);
        }

        static void Widerstand()
        {
            string intro = "Widerstandmenü";
            Console.WriteLine(intro.ToUpper());
            Console.WriteLine("\n");
            bool exit = false;
            bool subsubmenü = false;

            do
            {

                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Sie haben insgesamt 4 Auswahlen zur Verfügung.\n" +
                "Für die Formel, geben Sie bitte (1) ein.\n" +
                "Für den Nutze des Kondensators, bitte (2) eingeben.\n" +
                "Für die Definition des Kondensators, bitte (3) eingeben.\n");
                string auswahlmöglichkeiten = Convert.ToString(Console.ReadLine());

                switch (auswahlmöglichkeiten)
                {
                    case "1":
                        Console.Clear();
                        Widerstandformel();
                        break;

                    case "2":
                        Console.Clear();
                        Widerstandnutze();
                        break;

                    case "3":
                        Console.Clear();
                        Widerstanddefinition();
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Fehlermeldung!");
                        break;
                }

            } while (!exit & !subsubmenü);

            if (exit)
                Environment.Exit(0);

        }

        static void Widerstandformel()
        {
            string auswahl;
            string Intro = "Formel des Widerstandes";
            Console.WriteLine(Intro.ToUpper());
            bool subsubmenü = false;
            bool exit = false;

            do
            {


                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Sie haben Folgende möglichkeiten zu wählen:\nWiderstand und Leitwert(1)\n" +
                "Einheitswiderstand und Einheitsleitwert(2)\n" +
                "Leiterwiderstand(3)\n" +
                "Reihenschaltung von Widerständen(4)\n" +
                "Parallelschaltungen von Widerständen(5)\n");
                auswahl = Convert.ToString(Console.ReadLine());

                switch (auswahl)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Widerstand und Leitwert\n" +  
                        "R = Widerstand, G = Leitwert\n" +
                        "Formel für den Widerstand: G= 1/R\n" +
                        "Formel für den Leitwert: R= 1/G");
                        Console.WriteLine("\n");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Einheitswiderstand und Einheitsleitwert\n" +  
                        "P = Einheitswiderstand, hierbei kommts drauf an welchen Leiter wir haben.\n" +
                        "Beispielsleiter und ihre Werte: Silber = 0,016, Kupfer = 0,1786, Alluminium = 0,02857\n" +
                        "Das selbe jetzt mit K, K = Einheitsleitwert erneute Beispielsleiter und ihre Werte:\n" +
                        "Silber = 62,5, Kupfer = 56, Alluminium = 35\n" +
                        "Sprich Formel für den Einheitswiderstand: P = 1/K\n" +
                        "Formel für den Einheitsleitwert: K = 1/P");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Leiterwiderstand\n" + 
                        "R = der Leiterwiderstand, L = die Länge des Drahtes, A = der Querschnitt des Drahtes, K = Einheitsleitwert, P = Einheitswiderstand\n" +
                        "Formel für den Leiterwiderstand mit dem Einheitswiderstand: R = P*L/A\n" +
                        "Formel für den Leiterwiderstand mit dem Einheitsleitwert: R = L/K*A");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("Reihenschaltungen von Widerständen\n" +  
                        "Rges = Gesamtwiderstand = Der Gesamtteil von Teilwiderständen wie z.B. R1 + R2 + R3(wenn mehrere Teilwiderstände zur verfügung stehen erweitern!)\n" +
                        "Iges = Gesamtstrom stärke = Der Gesamtteil vom Strom zusammengesätzt wie z.B. I1 + I2 + I3(Hier ebenfalls, wenn mehrere Stromstärken zur verfügung stehen erweitern!)\n" +
                        "Uges = Gesamtspannung = Der Gesamtteil von der Spannung wie z.B. U1 + U2+ U3(ebenfalls, wenn mehrere Teilspannungen zur verfügung stehen erweitern!)\n" +
                        "Formel für den Gesamtwiderstand: Rges = R1 + R2 + R3(...)\n" +
                        "Formel für die Gesamtstrom stärke: Iges = I1 + I2 + I3(...)\n" +
                        "Formel für die Gesamtspannung: Uges = U1 + U2 + U3(...)");
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Parallelschaltugen von Widerständen\n" +  
                        "Hier gilt das selbe wie bei der Reihenschaltung:\n" +
                        "1/Rges = Gesamtwiderstand = Der Gesamtteil von Teilwiderständen wie z.B. 1/R1 + 1/R2 + 1/R3(wenn mehrere Teilwiderstände zur verfügung stehen erweitern!)\n" +
                        "1/Iges = Gesamtstrom stärke = Der Gesamtteil vom Strom zusammengesätzt wie z.B. 1/I1 + 1/I2 + 1/I3(Hier ebenfalls, wenn mehrere Stromstärken zur verfügung stehen erweitern!)\n" +
                        "1/Uges = Gesamtspannung = Der Gesamtteil von der Spannung wie z.B. 1/U1 + 1/U2 + 1/U3(ebenfalls, wenn mehrere Teilspannungen zur verfügung stehen erweitern!)\n" +
                        "Formel für den Gesamtwiderstand: 1/Rges = 1/R1 + 1/R2 + 1/R3(...)\n" +
                        "Formel für die Gesamtstrom stärke: 1/Iges = 1/I1 + 1/I2 + 1/I3(...)\n" +
                        "Formel für die Gesamtspannung: 1/Uges = 1/U1 + 1/U2 + 1/U3(...)");
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;

                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Fehlermeldung");
                        break;

                }
            } while (!exit & !subsubmenü);

            if (exit)
                Environment.Exit(0);
        }

        static void Widerstandnutze()
        {
            string intro = "nutze des Widerstandes";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {


                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Ein Widerstand ist ein zweipoliges passives elektrisches Bauelement.\n" +
                "Es realisiert einen ohmschen Widerstand in elektrischen und elektronischen Schaltungen.\n" +
                " Widerstände werden beispielsweise verwendet,um:\t den elektrischen Strom zu begrenzen,\n" +
                "den elektrischen Strom in einer Schaltung aufzuteilen,\n" +
                "den elektrischen Strom in eine Spannung umzuwandeln,\n" +
                "um ihn(indirekt) zu messen,\n" +
                "die elektrische Spannung in einer Schaltung aufzuteilen,\n" +
                "elektrische Energie in Wärmeenergie umzuwandeln\n");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch (auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            } while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);
        }

        static void Widerstanddefinition()
        {
            string intro = "Definition des Widertstandes";
            Console.WriteLine(intro.ToUpper());
            bool exit = false;
            bool subsubmenü = false;

            do
            {
                Console.WriteLine("\nUm das Programm zu schließen, bitte 'exit' eingeben!\n" +
                "Um ins vorherige Menü zu gelanden, bitte 'subsubmenü' eingeben!\n");

                Console.WriteLine("Der elektrische Widerstand ist in der Elektrotechnik ein Maß dafür, welche elektrische Spannung erforderlich ist,\n" +
                "um eine bestimmte elektrische Stromstärke durch einen elektrischen Leiter (Bauelement, Stromkreis) fließen zu lassen.\n" +
                "Dabei sind Gleichgrößen zu verwenden oder Augenblickswerte bei mit der Zeit veränderlichen Größen.");

                string auswahl = Convert.ToString(Console.ReadLine());
                switch (auswahl)
                {
                    case "exit":
                        Console.Clear();
                        exit = true;
                        break;

                    case "subsubmenü":
                        Console.Clear();
                        subsubmenü = true;
                        break;
                }

            } while (!exit & !subsubmenü);
            if (exit)
                Environment.Exit(0);
        }
                    
    }

}