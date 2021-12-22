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

            do   //Schleife (Anfang)
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

                //Bedienungsanleitung und Eingabeaufforderung
                Console.WriteLine("Wählen Sie bitte einen der folgenden Themenbereichen:\n");
                Console.WriteLine("\tO - Ohmsches Gesetz");
                Console.WriteLine("\tL - Leistungsgesetz\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();


                //Auswahl
                switch (HauptAusw)
                {

                    case "O":   //Möglichkeit 1
                        Console.Clear();
                        OhmschesGesetz();   //Ohmsches Gesetz Unterprogramm öffnen
                        break;

                    case "L":   //Möglichkeit 2
                        Console.Clear();
                        Leitungsgesetz();   //Leistungsgesetz Unterprogramm öffnen
                        break;

                    case "submenü":   //Möglichkeit 3
                        Console.Clear();
                        Hmenue = true;   //zurück zum Submenü
                        break;

                    case "exit":   //Möglichkeit 4
                        Exit = true;     //Programm schließen
                        break;

                    default:   //sonst

                        Console.WriteLine("Ungültige Eingabe");   //Anmerkung zur ungültigen Eingabe
                        Console.ReadKey();                        //Einlesung von Tastendruck

                        (int, int) cPosAM = Console.GetCursorPosition();


                        KonsolenExtrasBibliothek.ConsoleExtras.ClearCurrentConsoleLine(cPosBM.Item2, cPosAM.Item2);

                        break;
                }


            } while (!Exit & !Hmenue);   //Schleife (Ende)

            if (Exit)
                Environment.Exit(0);     //Exit
        }

        public static void OhmschesGesetz()   //1. Unterthema
        {

            Console.Clear();
            string oAuswahl;

            bool Exit = false;
            bool submenue = false;

            do   //Schleife (Anfang)
            {
                //Bedienungsanleitung und Eingabeaufforderung
                Console.WriteLine("               ---Ohmsches Gesetz---\n");
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü\n");
                Console.WriteLine("Über was genau möchten Sie Informationen erhalten?\n");
                Console.WriteLine("Geben Sie bitte für Definition und Bedeutung 1, für die Formel 2 und für Anwendungsgebiete und Beispiele 3 ein.\n");
                Console.Write("Eingabe:");
                oAuswahl = Console.ReadLine();

                switch (oAuswahl)
                {

                    case "1":   //Möglichkeit 1 (Definition und Bedeutung)
                        Console.Clear();

                        Console.Write("               Ohmsches Gesetz --- Definition und Bedeutung\n\n\n");

                        Console.Write("Das ohmsche Gesetz besagt: Die Stärke des durch ein Objekt fließenden elektrischen Stroms ist proportional der elektrischen Spannung." +
                                      "Oder umgekehrt:\nIst der als Quotient aus Spannung zu Stromstärke definierte elektrische Widerstand konstant," +
                                      "also unabhängig von Spannung und Stromstärke, so gilt am Objekt das ohmsche Gesetz; das Objekt hat dann ein ohmsches Verhalten.\n\n");

                        Console.Write("Der Gründer dieses Gesetzes ist Georg Simon Ohm, das Gesetz wurde ebenfalls nach ihm benannt," +
                                      "da er der erste war der diesen Zusammenhang für einige einfache elektrische Leiter nachweisen konnte.\n");

                        Console.Write("Jedoch gilt diese Annahme nur im engem Rahmen und auch nur für bestimmte Stoffe," +
                                      " z.B. besonders bei Metallen mit konstanter Temperatur." +
                                      "Heute wird das Ohmsche Gesetz als Definiton für Ohmsche Widerstände angesehen.");

                        Console.ReadKey();


                        break;


                    case "2":   //Möglichkeit 2 (Formel)
                        Console.Clear();

                        Console.Write("               Ohmsches Gesetz --- Formel\n\n\n");

                        Console.Write("R = U/I\n");

                        Console.Write("Das Verhältnis von elektrischer Spannung (U)," +
                                      "die an einem Elektrischen Leiter(Widerstand) anliegt," +
                                      "zur Stärke des elektrischen Stroms nennt man elektrischer Widerstand(R)\n");
                        Console.Write("Das ohmsche Gesetz betrachtet den Widerstand als eine von U und I unabhängige Konstante\n");
                        Console.Write("R = U/I = const.\n\n");

                        Console.Write("Die Gleichung des Ohmschen Gesetz lässt sich durch Äquivalenzumformungen in drei Schreibweisen darstellen:\n");

                        Console.Write("R = U/I, U = R*I und I = U/R\n\n");


                        Console.Write("Merkhilfe zum Ohmschen Gesetz:\n\n");


                        Console.Write("Merkdreieck:\n");

                        Console.Write("Man zeichnet ein Dreieck mit drei feldern und einem Strich der das Dreieck horizontal halbiert," +
                                      "Die untere Hälfte des Dreiecks wird erneut Vertikal halbiert.\n" +
                                      "Im oberen Feld steht ein U, im unteren linken ein R und im unteren rechten Feld steht ein I.\n");
                        Console.Write("Man deckt nun mit der Hand den Buchstaben ab, dessen Bedeutung man ausrechnen möchte\n" +
                                      "(z.B. Sie möchten den elektrischen Widerstand(R) ausrechnen und decken deshalb R ab.\n Sie sehen nurnoch das U," +
                                      "das I und den Strich der zwischen den beiden Buchstaben steht." +
                                      "Dieser Strich ist als geteilt zu verstehen und daher wäre die Rechnung dann U/I.");

                        Console.ReadKey();


                        break;


                    case "3":   //Möglichkeit 3 (Anwendungsgebiete und Beispiele)
                        Console.Clear();

                        Console.Write("               Ohmsches Gesetz --- Anwendungsgebiete\n\n\n");

                        Console.Write("Eigentlich gilt das ohmsche Gesetz nur für bestimmte Leiter, die sogenannten ohmschen Widerstände." +
                                      "Bei diesen besonderen Widerständen bleibt das Verhältnis aus Spannung und Stromstärke immer konstant.\n");
                        Console.Write("Das Ohmsche Gesetz kann zum Beispiel bei Reihenschaltungen, Parallelschaltungen und gemischten Schaltungen zum Einsatz kommen.\n\n");

                        Console.Write("Im Alltag wird das Ohmsche Gesetz in der Schule z.B. verwendet um Widerstände, Spannungen und Stromstärken in Schaltungen zu berechnen.\n");
                        Console.Write("Die meisten technischen Geräte, zum Beispiel Smartphones und Laptops,\nbenötigen zum Betrieb nicht nur eine bestimmte Spannung, sondern auch eine bestimmte Stromstärke. " +
                                      "Mit dem ohmschen Gesetz kann man berechnen,\n" +
                                      "welche Widerstände man in den Geräten verbauen muss, um auf den passenden Gleichstrom zu kommen.\n" +
                                      "Außerdem kann man auf ähnlichem Wege herausfinden welchen Widerstand man in einer elektrischen Hitzequelle,\n" +
                                      "wie einem elektrischen Wasserkocher oder einer Heizung verbauen muss damit man immernoch die gewünschte Temperatur erreicht\n");
                        Console.Write("Das ohmsche Gesetz kommt auch bei elektronischen Sicherungen zum Einsatz.\nDiese Bauteile verhindern, " +
                                      "dass die Bauteile innerhalb des Stromkreises bei einem Kurzschluss oder einer Überlastung beschädigt werden. " +
                                      "Mit dem ohmschen Gesetz kann berechnet werden,\nwas für eine Sicherung für den vorliegenden Stromkreis benötigt wird.\n\n");

                        Console.Write("Beispiele:\n");

                        Console.ReadKey();


                        break;


                    case "submenü":   //Möglichkeit 4 (Submenü)
                        Console.Clear();
                        submenue = true;   //zurück zum Submenü
                        break;

                    case "exit":   //Möglichkeit 5 (exit)
                        Console.Clear();
                        Exit = true;       //Programm schließen
                        break;

                    default:   //sonst

                        Console.WriteLine("Ungültige Eingabe");   //Anmerkung zur ungültigen Eingabe
                        Console.ReadKey();                        //Einlesung von Tastendruck

                        break;

                }

                Console.Clear();
            } while (!Exit & !submenue) ;   //Schleife (Ende)

            if (Exit)
                Environment.Exit(0);        //Exit

        }

        public static void Leitungsgesetz()   //2. Unterthema
        {

            Console.Clear();
            string lAuswahl;

            bool Exit = false;
            bool submenue = false;

            do   //Schleife (Anfang)
            {
                //Bedienungsanleitung und Eingabeaufforderung
                Console.WriteLine("               ---Leistungsgesetz---\n");
                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Submenü\n");
                Console.WriteLine("Über was genau möchten Sie Informationen erhalten?\n");
                Console.WriteLine("Geben Sie bitte für Definition und Bedeutung 1, für die Formel 2 und für Anwendungsgebiete und Beispiele 3 ein.\n");
                Console.Write("Eingabe:");
                lAuswahl = Console.ReadLine();

                switch (lAuswahl)
                {

                    case "1":   //Möglichkeit 1 (Definition und Bedeutung)
                        Console.Clear();

                        Console.Write("               Elektrische Leistung --- Definiton und Bedeutung\n\n\n");

                        Console.Write("Die elektrische Leistung gibt an wieviel elektrische Energie in einer gewissen Zeit umgesetzt wird, sie beschreibt den Energieverbrauch.\n");
                        Console.Write("Die elektrische Leistung beschreibt auch wieviel elektrische Energie in einer gewissen Zeit in andere Formen von Energie umgewandelt werden.\n");

                        Console.Write("P steht in Rechnungen für die elektrische Leistung.");
                        Console.Write("Die Einheit der elektrischen Leistung ist Watt (W)");
                        Console.Write("[P] = 1W\n\n");


                        Console.Write("Früher wurde die elektrische Leistung in Pferdestärken(PS) angegeben. (1PS = 735,5W)\n\n");

                        Console.Write("In der Elektrotechnik tritt die elektrische Leistung in folgenden Größen auf:\nMikrowatt (µW = 1*10-6W)\nMilliwatt (mW = 1*10⁻³W)\n" +
                                      "Kilowatt (kW = 1*10³W)\nMegawatt (MW = 1*10⁶W)\n");
                        Console.Write("Die verschiedenen Größen entsprechen: 1W = 1000mW, 1mW = 1000µW und 1MW = 1000kW, 1kW = 1000W");

                        Console.ReadKey();


                        break;


                    case "2":   //Möglichkeit 2 (Formel)
                        Console.Clear();

                        Console.Write("               Elektrische Leistung --- Formel\n\n\n");

                        Console.Write("Die wichtigste Formel der elektrischen Leistung lautet:\n\n");

                        Console.Write("P = U/I");
                        Console.Write("P entspricht der elektrischen Leistung in Watt, U der elektrischen Spannung in Volt und I der elektrischen Stromstärke in Ampere.\n");
                        Console.Write("Die elektrische Leistung ist das Produkt aus elektrischer Spannung und elektrischem Strom, das bedeutet das die elektrische Leistung ebenfalls vergrößert wird,\n" +
                                      "jenachdem wie groß die elektrische Spannung und der elektrische Strom ist.\n");

                        Console.Write("Mithilfe des Ohmschen Gesetzes können weitere Formeln aus dieser hergelitten werden.");

                        Console.ReadKey();


                        break;


                    case "3":   //Möglichkeit 3 (Anwendungsgebiete und Beispiele)
                        Console.Clear();

                        Console.Write("               Elektrische Leistung --- Anwendungsgebiete und Beispiele\n\n\n");

                        Console.Write("Die elektrische Leistung benötigt man um angeben zu können wieviel elektrische Energie in einer gewissen Zeit umgesetzt wird.\n" +
                                      "So kann man ausdrücken wieviel Energie z.B. ein Toaster umsetzt.\n\n\n");

                        Console.Write("Beispiel:\n\n");

                        Console.Write("Frage:\n");
                        Console.Write("Eine Glühbirne wird mit der Spannung 230 Volt und einer Stromstärke von 0,2 Ampere betrieben. Welche Leistung besitzt die Glühbirne?\n\n");

                        Console.Write("Lösung:\n");
                        Console.Write("Du hast sowohl die Spannung U gegeben als auch die Stromstärke I, deshalb kannst du direkt die Formel benutzen und die beiden Werte einsetzen:");
                        Console.Write("P=U*I = 230V * 0,2A = 46 Watt\n\n");

                        Console.Write("Antwort:\n");
                        Console.Write("Die elektrische Leistung der Glühbirne beträgt 46 Watt");

                        Console.ReadKey();


                        break;


                    case "submenü":   //Möglichkeit 4 (Submenü)
                        Console.Clear();
                        submenue = true;   //zurück zum Submenü
                        break;

                    case "exit":   //Möglichkeit 5 (exit)
                        Console.Clear();
                        Exit = true;       //Programm schließen
                        break;

                    default:   //sonst

                        Console.WriteLine("Ungültige Eingabe");   //Anmerkung zur ungültigen Eingabe
                        Console.ReadKey();                        //Einlesung von Tastendruck

                        break;

                }

                Console.Clear();
            } while (!Exit & !submenue) ;   //Schleife (Ende)

            if (Exit)
                Environment.Exit(0);        //Exit

        }
    }
}
