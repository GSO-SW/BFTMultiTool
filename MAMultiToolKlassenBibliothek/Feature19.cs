using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace MAMultiToolKlassenBibliothek
{
    class Feature19
    {
        public static void Feature19Funcion1()
        {
            Console.WriteLine("Featur19 SubSubMenue");

            string HauptAusw;

            bool Exit = false;
            bool submenü;

            do
            {
                (int, int) cPosBM = Console.GetCursorPosition();

                Console.WriteLine();

                
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));

               
                Console.Title = "BFTMultiTool";

                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Mathematikrechner: Flächenberechnung verschiedener Formen <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Eingabe: exit\t\t->\tbeendet das Programm");
                Console.WriteLine("Eingabe: submenü\t->\tzurück zum MatheSubMenü");

                
                Console.WriteLine("\n\nHier können Sie zwischen vielen verschiedenen Möglichkeiten wählen, zum Flächenberechnen von verschiedenen Formen. \n");

                submenü = false;

               
                Console.WriteLine("Wählen Sie eine der folgenden möglichkeiten zum Flächeninhalt berechnen:\n");
                Console.WriteLine("\t1 - Flächeninhalt vom Quadrat berechnen ");
                Console.WriteLine("\t2 - Flächeninhalt vom rechteck berechnen ");
                Console.WriteLine("\t3 - Flächeninhalt vom allgemeinen Dreieck berechnen");
                Console.WriteLine("\t4 - Flächeninhalt vom rechtwinkligen Dreieck berechnen");
                Console.WriteLine("\t5 - Flächeninhalt vom gleichschenkligen Dreieck berechnen");
                Console.WriteLine("\t6 - Flächeninhalt vom gleichseitigen Dreieck berechnen");
                Console.WriteLine("\t7 - Flächeninhalt vom Trapez berechnen");
                Console.WriteLine("\t8 - Flächeninhalt vom Parallelogramm berechnen");
                Console.WriteLine("\t9 - Flächeminhalt von einer Raute berechnen");
                Console.WriteLine("\t10 - Flächeninhalt vom Kreis berechnen");


                Console.Write("Eingabe:");
                HauptAusw = Console.ReadLine();

                switch (HauptAusw)
                {

                    case "1":
                        Console.Clear();
                        Quadratberechnen();
                        break;

                    case "2":
                        Console.Clear();
                        Rechteckberechen();

                        break;

                    case "3":
                        Console.Clear();
                        AllgemeinesDreieck();

                        break;

                    case "4":
                        Console.Clear();
                        rechtwinkligesDreieck();

                        break;

                    case "5":
                        Console.Clear();
                        gleichwinkligesDreieck();

                        break;

                    case "6":
                        Console.Clear();
                        gleichseitigesDreieck();

                        break;

                    case "7":
                        Console.Clear();
                        Trapez();

                        break;

                    case "8":
                        Console.Clear();
                        Parallelogramm();

                        break;

                    case "9":
                        Console.Clear();
                        Raute();

                        break;

                    case "10":
                        Console.Clear();
                        Kreis();

                        break;

                    case "submenü":
                        Console.Clear();
                        submenü = true;
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


            } while (!Exit & !submenü);

            if (Exit)
                Environment.Exit(0);
        }

        static void Quadratberechnen()
        {
            bool subexit = false;
            bool wiederholen = true;
            do
            {
               

                Double a = 0;
                string s_a;
                bool tryparseout;



                Console.WriteLine("Quadrat berechnen");

                do
                {
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                    if(s_a=="exit")
                    {
                        Environment.Exit(0);
                    }
                    else if(s_a=="subexit")
                    {
                        subexit = true;
                    }

                    tryparseout = double.TryParse(s_a, out a);
                } while (tryparseout == false && subexit==false);




                if (a < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0)
                {
                    Double A = a * a;
                    Console.WriteLine("Der flächeninhalt des Quadrats beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();
            
           
              
               
            } while (wiederholen==true && subexit==false);
                


        }

        static void Rechteckberechen()
        {
           
            bool wiederholen = true;
            do
            {
                

                Double a = 0, b = 0;
                string s_a, s_b;
                bool tryparseout;

                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_b =Console.ReadLine();


                    tryparseout = double.TryParse(s_a, out a);
                    tryparseout = double.TryParse(s_b, out b);
                } while (tryparseout == false);

                if (a < 0 && b < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0 && b > 0)
                {
                    Double A = a * b;
                    Console.WriteLine("Der flächeninhalt des Rechtecks beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void AllgemeinesDreieck()
        {
           
            Double g = 0, h = 0;
            string s_g, s_h;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
               
                do
                {
                    
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_g = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_h = Console.ReadLine();


                    tryparseout = double.TryParse(s_h, out h);
                    tryparseout = double.TryParse(s_g, out g);
                } while (tryparseout == false);

                if (g < 0 && h < 0)
            {
                Console.WriteLine("Falsche Eingabe");
                Console.ReadLine();
                wiederholen = true;
            }
            else if (g > 0 && h > 0)
            {
                Double A = g * h / 2 ;
                Console.WriteLine("Der flächeninhalt des Allg. Dreiecks beträgt {0}", A);
                Console.WriteLine("Wiederholen?(true/false)");
                wiederholen = Convert.ToBoolean(Console.ReadLine());

            }




            Console.Clear();

        } while (wiederholen == true);
        }

        static void rechtwinkligesDreieck()
        {
            Double a = 0, b = 0;
            string s_a, s_b;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
               
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_b = Console.ReadLine();


                    tryparseout = double.TryParse(s_a, out a);
                    tryparseout = double.TryParse(s_b, out b);
                } while (tryparseout == false);

                if (a < 0 && b < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0 && b > 0)
                {
                    Double A = (a * b) / 2;
                    Console.WriteLine("Der flächeninhalt des RechtWinkligen Dreiecks beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void gleichwinkligesDreieck()
        {
            
            Double c = 0, h = 0;
            string s_c, s_h;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
               
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_c = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_h = Console.ReadLine();


                    tryparseout = double.TryParse(s_c, out c);
                    tryparseout = double.TryParse(s_h, out h);
                } while (tryparseout == false);

                if (c < 0 && h < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (c > 0 && h > 0)
                {
                    Double A = 0.5 * c * h;
                    Console.WriteLine("Der flächeninhalt des Rechtwinkligem Dreieck beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void gleichseitigesDreieck()
        {
           
            Double a = 0;
            string s_a;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
                
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                   


                    tryparseout = double.TryParse(s_a, out a);
                   
                } while (tryparseout == false);

                if (a < 0 )
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0)
                {
                    Double A = ((a * a) /4) * Math.Sqrt(3);
                    Console.WriteLine("Der flächeninhalt des Gleichseitigem Dreiecks beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void Trapez()
        {
            
            Double a = 0, c = 0, h = 0;
            string s_a, s_c, s_h;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von c ein");
                    s_c = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von h ein");
                    s_h = Console.ReadLine();


                    tryparseout = double.TryParse(s_a, out a);
                    tryparseout = double.TryParse(s_c, out c);
                    tryparseout = double.TryParse(s_h, out h);
                } while (tryparseout == false);

                if (a < 0 && c < 0 && h < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0 && c > 0 && h > 0)
                {
                    Double A = (a + c / 2) * h;
                    Console.WriteLine("Der flächeninhalt des Trapez beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void Parallelogramm()
        {
           
            Double a = 0, h = 0;
            string s_a, s_h;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
               

                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_a = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_h = Console.ReadLine();


                    tryparseout = double.TryParse(s_a, out a);
                    tryparseout = double.TryParse(s_h, out h);
                } while (tryparseout == false);

                if (a < 0 && h < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (a > 0 && h > 0)
                {
                    Double A = a * (h * h) ;
                    Console.WriteLine("Der flächeninhalt des Parallelogramm beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void Raute()
        {
            
            Double e = 0, f = 0;
            string s_e, s_f;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
                
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_e = Console.ReadLine();
                    Console.WriteLine("Geben sie den Wert von b ein");
                    s_f = Console.ReadLine();


                    tryparseout = double.TryParse(s_e, out e);
                    tryparseout = double.TryParse(s_f, out f);
                } while (tryparseout == false);

                if (e < 0 && f < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (e > 0 && f > 0)
                {
                    Double A = (1 / 2) * e * f;
                    Console.WriteLine("Der flächeninhalt der Raute beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }

        static void Kreis()
        {
            
            Double r = 0;
            string s_r;
            bool tryparseout;
            bool wiederholen = true;
            do
            {
                do
                {
                    Console.WriteLine("Rechteck berechnen");
                    Console.WriteLine("Geben sie den Wert von a ein");
                    s_r = Console.ReadLine();
                   
                    tryparseout = double.TryParse(s_r, out r);
                } while (tryparseout == false);


                if (r < 0)
                {
                    Console.WriteLine("Falsche Eingabe");
                    Console.ReadLine();
                    wiederholen = true;
                }
                else if (r > 0)
                {
                    Double A = 3.14 * (r * r);
                    Console.WriteLine("Der flächeninhalt des Kreises beträgt {0}", A);
                    Console.WriteLine("Wiederholen?(true/false)");
                    wiederholen = Convert.ToBoolean(Console.ReadLine());

                }




                Console.Clear();

            } while (wiederholen == true);
        }
    }

}


        
    
