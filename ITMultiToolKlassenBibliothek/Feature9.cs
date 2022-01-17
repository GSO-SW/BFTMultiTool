using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMultiToolKlassenBibliothek
{
    class Feature9
    {
        public static void Feature9Funcion1()
        {
            Console.WriteLine("Feature9 SubSubMenue");

            Console.WriteLine("");

            Console.WriteLine(" Bitte Wählen Sie ein Zahlensystem\n");
            Console.WriteLine("\t1 - Hexadezimal\n");
            Console.WriteLine("\t2 - Dezimal\n");
            Console.WriteLine("\t3 - Oktal\n");
            Console.WriteLine("\t4 - Binar\n");

            string Zahlensystem = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie den Wert ein");
            double Wert = Convert.ToDouble(Console.ReadLine());




        }
    }
}
