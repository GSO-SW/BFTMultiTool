using System;
using Figgle;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace WIMultiToolKlassenBibliothek
{
    class Feature15
    {
        public static void Feature15Funcion1()
        {
            Console.WriteLine("Feature15 SubSubMenue");
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
                                                          " >>> Wirtschaft: Lohnsteuerberechnung <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum Hauptmenü");
                Console.WriteLine("\n\nHier können Sie ihre Lohnsteuer mit ihrem bmgl berechnen \n\n");
                Submenü = false;

                Console.WriteLine("Wählen Sie eine der folgenden zahlen um fortzufahren:\n");
                Console.WriteLine("\t1 - Lohnsteuer");
                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();



                switch (HauptAusw)
                {
                    case "1":
                        Console.Clear();
                        Lohnsteuer();

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
        public static void Lohnsteuer()

        {
            bool wiederholen = true;
            do
            {
                string str_num1;
                string Wort;
                int num1 = 0;
                bool tryparseout;
                do
                {
                    Console.WriteLine("Bitte Tragen sie ihren Bmgl ein.");                                                   //Nach Bmgl Fragen

                    str_num1 = Console.ReadLine();                                                                           //Das ist halt da für ungültige zeichen

                    tryparseout = int.TryParse(str_num1, out num1);                                                         //Das ist    halt da für ungültige zeichen  
                    Console.Clear();                                                                                    //macht die anderen zeichen da weg

                } while (tryparseout == false);                                                                             //Das ist halt da für ungültige zeichen         

                if (num1 >= 1 & num1 < 11000)                                                                             //wenn kleiner als 110000
                {
                    Console.WriteLine("Sie Haben 0 Euro an lohnsteuern zu zahlen");                                       //den text da ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                            //Bedanken auf ganz süß
                    Console.ReadLine();                                                                                  //Programm schließen
                }
                else if (num1 >= 11000 & num1 <= 18000)                                                                  //wenn größer als 11000 und kleiner gleich 18000 ist
                {

                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 25 + "Euro"));                      //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                     //Bedanken auf ganz süß
                    Console.ReadLine();
                }
                else if (num1 > 18000 & num1 <= 31000)                                                           //wenn größer als 18000 und kleiner gleich 31000 ist
                {
                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 35 + " Euro"));                    //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                      //Bedanken auf ganz süß
                    Console.ReadLine();
                }
                else if (num1 > 31000 & num1 <= 60000)                                                           //wenn größer als 31000 und kleiner gleich 60000 ist
                {
                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 42 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                   //Bedanken auf ganz süß
                    Console.ReadLine();
                }
                else if (num1 > 60000 & num1 <= 90000)                                                           //wenn größer als 60000 und kleiner gleich 90000 ist
                {
                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 48 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                    Console.ReadLine();
                }
                else if (num1 > 90000 & num1 <= 100000)                                                           //wenn größer als 90000 und kleiner gleich 100000 ist 
                {

                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 50 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                    Console.ReadLine();
                }
                else if (num1 > 100000)                                                                           //wenn größer als 100000
                {
                    Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 55 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                    Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                    Console.ReadLine();
                }

                do
                {
                    Console.ReadKey();
                    Console.WriteLine("Möchten sie das Proggramm Wiederholen?(Ja/Nein)");                           //fragt nach ob du es nochmal verwenden willst
                    Wort = Console.ReadLine().ToLower();
                } while (Wort != "ja" && Wort != "nein");                                                           //solange wort nicht ja /nicht nein ist

                if (Wort == "Ja")                                                                                   //bei ja wiederholen
                {
                    wiederholen = true;
                }
                else if (Wort == "nein")                                                                            //bei nein zurück ins menu
                {
                    wiederholen = false;
                }
                Console.Clear();                                                                                    //macht die anderen zeichen da weg
            } while (wiederholen);


        }
    }
}