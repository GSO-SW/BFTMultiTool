using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMultiToolKlassenBibliothek
{
    class Feature15
    {
        public static void Feature15Funcion1()
        {
            int num1 = 0; 
            Console.WriteLine("Feature15 SubSubMenue");
            Console.WriteLine("Wilkommen Zur Lohnsteuerberechnung.");  //Begrüßung
            Console.WriteLine("Bitte Tragen sie ihren Bmgl ein.");     //Nach Bmgl Fragen
            num1 = Convert.ToInt32(Console.ReadLine());
            {
                while (num1 > 0)
                {
                    Console.WriteLine($"i: {num1}");
                    num1++;
                    if (num1 == 0)
                    { break;
                        Console.WriteLine("wow");
                }
            }
        }
    }
    }
}