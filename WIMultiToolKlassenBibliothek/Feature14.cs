using System;
using Figgle;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMultiToolKlassenBibliothek
{
    class Feature14
    {

        public static void Feature14Funcion1()
        {
            Console.WriteLine("Feature14 SubSubMenue");
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
                                                    " >>> Wirtschaft: Amortisationsrechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");
                Console.WriteLine("\n\nHier können Sie ihre Amortisationsrechnung berechnung \n\n");
                Submenü = false;

                Console.WriteLine("Wählen Sie die 1 um fortzufahren:\n");
                Console.WriteLine("\t1 - Amortisation");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Amortisation();

                        break;

                    case "submenü":
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

        }

        public static void Amortisation()
        {
            string str_fixkosten;
            double doub_fixkosten;
            string str_PpP;
            double doub_PpP;
            string str_Variablekosten;
            double doub_Variablekosten;
            string str_wiederholen;
            bool wiederholen;
            bool tryparseout;
            do
            {
                Console.WriteLine("Amortisation");
                do
                {
                    Console.WriteLine("Eingabe von Fixkosten");
                    str_fixkosten = Console.ReadLine();
                    tryparseout = double.TryParse(str_fixkosten, out doub_fixkosten);
                } while (tryparseout == false);
                do
                {
                    Console.WriteLine("Eingabe von Variable kosten");
                    str_Variablekosten = Console.ReadLine();
                    tryparseout = double.TryParse(str_Variablekosten, out doub_Variablekosten);
                } while (tryparseout == false);
                do
                {
                    Console.WriteLine("eingabe von pro stückkosten");
                    str_PpP = Console.ReadLine();
                    tryparseout = double.TryParse(str_PpP, out doub_PpP);
                } while (tryparseout == false);
                double GpS = doub_PpP - doub_Variablekosten;
                Console.WriteLine("{0,-20}{1,20:F2}EUR", "Gewin pro Stück", GpS);
                double Vz = doub_fixkosten / GpS;
                Console.WriteLine("{0,-20}{1,20:F2}", "Verkaufszahl", Vz);
                Console.ReadKey();
                do
                {
                    Console.WriteLine("Wiederholen?(true/false)");
                    str_wiederholen = Console.ReadLine();
                    tryparseout = bool.TryParse(str_wiederholen, out wiederholen);
                } while (tryparseout == false);
                Console.Clear();
            } while (wiederholen);
        }
    }
}