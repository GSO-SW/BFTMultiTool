using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;
namespace MAMultiToolKlassenBibliothek
{
    class Feature16
    {
        public static void Feature16Funcion1()
        {
            Console.WriteLine("Feature16 SubSubMenue test");

            string HauptAusw;

            bool Exit = false;
            bool Submenü;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

                
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Satz des Pythagorasrechner: <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: Submenü\t->\tzurück zum Submenü");

                
                Console.WriteLine("\n\nWillkommen im Rechner zum Satz des Pythagoras, bitte wählen sie eine Seite aus die Sie berechnen möchten!\n\n");

                Submenü = false;

                
                Console.WriteLine("Wählen Sie eine der folgenden Seiten die Sie berechnen möchten:\n");
                Console.WriteLine("\t1 - Kathete");
                Console.WriteLine("\t2 - Ankathete");
                Console.WriteLine("\t3 - Hypotenuse\n");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Kathete();

                        break;

                    case "2":
                        Console.Clear();
                        Ankathete();

                        break;

                    case "3":
                        Console.Clear();
                        Hypotenuse();

                        break;

                    case "Submenü":
                        Console.Clear();
                        Submenü = true;
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


            } while (!Exit & !Submenü);

            if (Exit)
                Environment.Exit(0);

            static void Kathete()
            {
                Console.WriteLine
                   (FiggleFonts.Slant.Render("BFTMultiTool"));


                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Berechnung der Kathete: <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");


                Console.WriteLine("Geben Sie die Länge der Hypotenuse an:");
                Double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie die Länge der Ankathete an:");
                Double b = Convert.ToDouble(Console.ReadLine());
                Double B = (b * b);
                Double C = (c * c);
                Double A = (C - B);
                Double a = Math.Sqrt(A);
                Console.WriteLine($"Die Kathete hat die folgende länge: {a} ");




            }

            static void Ankathete()
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));


                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Berechnung der Ankathete: <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");



                Console.WriteLine("Geben Sie die Länge der Hypotenuse an:");
                Double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie die Länge der Kathete an:");
                Double a = Convert.ToDouble(Console.ReadLine());
                Double C = (c * c);
                Double A = (a * a);
                Double B = (C - A);
                Double b = Math.Sqrt(B);
                Console.WriteLine($"Die Ankathete hat die folgende länge: {b} ");




            }

            static void Hypotenuse()
            {
                Console.WriteLine
                   (FiggleFonts.Slant.Render("BFTMultiTool"));


                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Berechnung der Hypotenuse: <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");



                Console.WriteLine("Geben Sie die Länge der Kathete an:");
                Double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Geben Sie die Länge der Ankathete an:");
                Double b = Convert.ToDouble(Console.ReadLine());
                Double B = (b * b);
                Double A = (a * a);
                Double C = (A + B);
                Double c = Math.Sqrt(C);
                Console.WriteLine($"Die Hypotenuse hat die folgende länge: {c} ");




            }






        }

    }
}
