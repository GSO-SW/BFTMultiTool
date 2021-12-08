using System;
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
            int num1 = 0;

            while (num1 > 0)
                Console.WriteLine("Feature15 SubSubMenue");                                                                     //idk war schon da xD
            Console.WriteLine("Wilkommen Zur Lohnsteuerberechnung.");                                                      //Begrüßung
            Console.WriteLine("Bitte Tragen sie ihren Bmgl ein.");                                                        //Nach Bmgl Fragen
            num1 = int.Parse(Console.ReadLine());                                                                        //einsetzen bzw gucken ob das da zu den if dingern passt            

            if (num1 >= 1 & num1 < 11000)                                                                                           //wenn kleiner als 110000
            {
                Console.WriteLine("Sie Haben 0 Euro an lohnsteuern zu zahlen");                                       //den text da ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                      //Bedanken auf ganz süß
                Console.ReadLine();                                                                                  //Programm schließen
            }
            else if (num1 > 11000 & num1 <= 18000)                                                                  //wenn größer als 11000 und kleiner gleich 18000 ist
            {

                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 25 + "Euro"));                      //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                     //Bedanken auf ganz süß
                Console.ReadLine();                                                                            //Programm schließen
            }
            else if (num1 == 0)
            {
                var prs = new ProcessStartInfo("Chrome.exe");
                prs.Arguments = "https://youtu.be/dQw4w9WgXcQ";
                Process.Start(prs);

            }
            else if (num1 > 18000 & num1 <= 31000)                                                           //wenn größer als 18000 und kleiner gleich 31000 ist
            {
                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 35 + " Euro"));                    //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                      //Bedanken auf ganz süß
                Console.ReadLine();                                                                           //Programm schließen
            }
            else if (num1 > 31000 & num1 <= 60000)                                                           //wenn größer als 31000 und kleiner gleich 60000 ist
            {
                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 42 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                   //Bedanken auf ganz süß
                Console.ReadLine();                                                                            //Programm schließen
            }
            else if (num1 > 60000 & num1 <= 90000)                                                           //wenn größer als 60000 und kleiner gleich 90000 ist
            {
                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 48 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                Console.ReadLine();                                                                         //Programm schließen
            }
            else if (num1 > 90000 & num1 <= 100000)                                                           //wenn größer als 90000 und kleiner gleich 100000 ist 
            {

                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 50 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                Console.ReadLine();                                                                         //Programm schließen
            }
            else if (num1 > 100000)                                                                           //wenn größer als 100000
            {
                Console.WriteLine($"Ihre Lohnsteuer Beträgt:" + (num1 / 100 * 55 + " Euro"));                  //ausrechnen und Lohnsteuer ausgeben
                Console.WriteLine("Wir Bedanken uns das sie unseren Programm verwenden");                    //Bedanken auf ganz süß
                Console.ReadLine();                                                                         //Programm schließen



            }
        }
    }
}

