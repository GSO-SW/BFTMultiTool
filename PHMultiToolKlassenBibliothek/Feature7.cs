using System;
using Figgle;
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





        }

        public static void VierGrundflächeDerPhysik()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Vier Grundfläche der Physik <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Der Flächeninhalt ist ein Maß für die Größe einer Fläche." +
                " Unter Fläche versteht man dabei zweidimensionale Gebilde, das heißt solche, in denen man sich in zwei unabhängige Richtungen bewegen kann." +
                " Darunter fallen die üblichen Figuren der ebenen Geometrie wie Rechtecke, Polygone, Kreise, aber auch Begrenzungsflächen dreidimensionaler Körper wie Quader, Kugel, Zylinder usw." +
                " Für viele Anwendungen genügen diese Flächen bereits, komplexere Flächen lassen sich oft aus diesen zusammensetzen oder durch diese annähern." +
                " Der Flächeninhalt spielt in der Mathematik, bei der Definition vieler physikalischer Größen, aber auch im Alltag eine wichtige Rolle." +
                " So ist etwa Druck als Kraft pro Fläche definiert oder das magnetische Moment einer Leiterschleife als Strom mal umflossene Fläche.Grundstücks - und Wohnungsgrößen werden durch Angabe ihrer Grundfläche vergleichbar." +
                " Materialverbrauch, beispielsweise von Saatgut für ein Feld oder Farbe zum Anstreichen einer Fläche, kann mit Hilfe des Flächeninhalts abgeschätzt werden." +
                " Der Flächeninhalt ist normiert in dem Sinne, dass das Einheitsquadrat, das heißt das Quadrat mit Seitenlänge 1, den Flächeninhalt 1 hat; in Maßeinheiten ausgedrückt, hat ein Quadrat mit der Seitenlänge 1 m den Flächeninhalt 1 m2." +
                " Um Flächen durch ihren Flächeninhalt vergleichbar zu machen, muss man fordern, dass kongruente Flächen denselben Flächeninhalt haben und dass sich der Flächeninhalt zusammengesetzter Flächen als Summe der Inhalte der Teilflächen ergibt.");





        }

        public static void WoherKommtDieMasse()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Woher kommt die Masse ? <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Diese Frage wollen Physiker vom kommenden Jahr an mit Messungen am 27 Kilometer langen Kreisbeschleuniger, dem Large Hadron Collider (LHC) des Forschungszentrums CERN in Genf, beantworten." +
                " Ganz ohne diese aufwändigen Experimente berechnete nun ein internationales Forscherteam erstmals die Masse der wichtigsten Baustein der Materie, Protonen und Neutronen." +
                " Ihre Computersimulationen, die sie in der Zeitschrift ,,Science,, präsentieren, untermauern die komplexe Theorie der Quantenchromodynamik." +
                " Mehr als 99,9 Prozent der Masse der sichtbaren Materie stammen von den Protonen und Neutronen, sagt Zoltan Fodor, der das Forschungsprojekt am Jülicher Supercomputer JUGENE geleitet hat." +
                " Doch die Masse dieser Bausteine, aus denen sich alle Atomkerne zusammensetzen, ist nicht leicht greifbar." +
                " Denn im einfachsten Modell bestehen sie nur aus drei Quarks." +
                " Die Masse der drei Quarks bringt zusammengerechnet jedoch nur etwa fünf Prozent der Masse eines Kernbausteins auf die Waage." +
                " Die restlichen 95 Prozent verbergen sich in der starken Kraft, die die drei Quarks zusammenhält.");




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
            Console.WriteLine("--------------------------------------------------------------------\n" +
                              "                              >>> ´Atomkern <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(" Der Atomkern besteht aus Protonen und Neutronen, die zusammen auch Nukleonen genannt werden." +
                " Er befindet sich, anschaulich gesprochen, im Zentrum des Atoms und ist etwa 10.000 bis 100.000 mal kleiner als die Elektronenhülle, konzentriert aber in sich mehr als 99,9 % der Masse/Energie des gesamten Atoms." +
                " Die Gesamtzahl der Nukleonen im Kern heißt deshalb auch Massenzahl." +
                " Mit steigender Massenzahl nimmt allgemein die Dichte des Materials zu." +
                " Beispielsweise wiegt Lithium(Massenzahl 6 und 7) 0, 53 g / cm³, Gold(Massenzahl 197) dagegen 19, 3 g / cm³." +
                " Sogenannte schwere Atomkerne gehören also zu auch umgangssprachlich / technisch schweren Elementen." +
                " Neutronen besitzen keine elektrische Ladung.Protonen sind jedoch positiv geladen." +
                " Infolgedessen ist der Atomkern elektrisch positiv geladen und kann über die Coulombkraft negativ geladene Elektronen an sich binden." +
                " Da die elektrische Ladung des Elektrons bis auf das Vorzeichen gleich der Ladung des Protons ist, muss ein nach außen hin elektrisch neutrales Atom ebenso viele Elektronen in der so genannten Elektronenhülle besitzen, wie Protonen im Kern." +
                " In diesem Zustand befinden sich die Atome nur als chemische Elemente.Werden durch chemische Effekte Elektronen entfernt oder hinzugefügt, sind die Atome nach außen hin elektrisch geladen und werden Ionen genannt." +
                " Im Atomkern ändert sich dadurch nichts.");



             





        }

        public static void KernUndRadio()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Kernumwandlung und Radioaktivität <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Kernspaltung:" +
                "Kernfusion(Verschmelzung von Atomkernen)" +
                "Natürliche Radioaktivität:" +
                "In der Natur vorkommende Radionuklide wandeln sich spontan unter Aussendung von radioaktiver Strahlung um." +
                "" +
                "Beispiel:" +
                "Radium wandelt sich unter Aussendung von Alphastrahlung spontan in Radon um:" +
                "Radium 226 → Radon 222 + α - Teilchen" +
                "(Dabei sind die Zahlen hinter den chemischen Symbolen die Massenzahlen." +
                "" +
                "Künstliche Radioaktivität:" +
                "Durch Beschuss mit Neutronen o.Ä.kommt es zur Umwandlung von Atomkernen.");

            Console.WriteLine("Radioaktivität:" +
                "Unter Radioaktivität versteht man die Erscheinung, dass sich Atomkerne unter Abgabe von(ionisierender) Strahlung verändern." +
                "HENRI BECQUEREL(1852–1908) erhielt 1903 zusammen mit MARIE CURIE(1867– 1934) und PIERRE CURIE(1859–1906) für die Verdienste um die Entdeckung und Erforschung der Radioaktivität den Nobelpreis für Physik." +
                "Marie und Pierre Curie entdeckten 1898 die radioaktiven Elemente Radium und Polonium.Auf Marie Curie geht auch der Begriff „Radioaktivität“ zurück." +
                "Atomkerne, die sich verändern, werden als radioaktive Nuklide oder Radionuklide bezeichnet. Dabei ist zwischen natürlicher und künstlicher Radioaktivität zu unterscheiden." +
                "Spezielle Arten von Kernumwandlungen sind die Kernspaltung und die Kernfusion. Unter einer Kernumwandlung oder Kernreaktion versteht man im Allgemeinen die Umwandlung von Atomkernen in neue Kerne." +
                "Eine solche Umwandlung kann geschehen durch:" +
                "spontanen Zerfall(→ natürliche Radioaktivität; dazu gehört auch die kosmische Strahlung)" +
                "Beschuss mit Teilchen(→ künstliche Radioaktivität)");







        }

        public static void Kernspaltung()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                              "                              >>> ´Kernspaltung <<<\n" +
                              "------------------------------------------------------------------------------------\n\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(" Unter Kernspaltung versteht man die durch Beschuss mit Neutronen erfolgende Zerlegung eines schweren Atomkerns in zwei mittelschwere Atomkerne." +
                " Dabei werden Neutronen freigesetzt und es wird Energie abgegeben, die als Kernenergie bezeichnet wird." +
                " Kernspaltung ist eine spezielle Form der Kernumwandlung, d.h. der Umwandlung von Atomkernen in neue Kerne." +
                " Ein Beispiel für eine solche Kernspaltung ist in Bild 1 dargestellt: Treffen Neutronen auf Uran - 235, so erfolgt eine Kernumwandlung in Uran - 236, das in Bruchteilen von Sekunden in zwei mittelschwere Kerne zerfällt." +
                " In Bild 1 ist nur eine Möglichkeit dargestellt. Ein Urankern kann auch in andere Atomkerne zerfallen, z.B. in Lanthan und Brom, in Selen und Caesium oder in Antimon und Niobium." +
                " Insgesamt sind über 200 Zerfallsprodukte des Urans bekannt.Bei jeder Kernspaltung werden 2 oder 3 Neutronen freigesetzt." +
                " Allgemein gilt: (Durch Beschuss mit langsamen Neutronen können schwere Atomkerne(z.B.Uran, Plutonium) in mittelschwere Atomkerne aufgespalten werden." +
                " Dabei werden Neutronen freigesetzt und es wird Energie abgegeben.)");




        }
        
       
    }
      
}