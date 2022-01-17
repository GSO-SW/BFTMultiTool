using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMultiToolKlassenBibliothek
{
    class Feature13
    {
        public static void Feature13Funcion1()
        {
            double kapital = 0;
            double zinssatz = 0;
            double jahre = 0;
            double gewinn = 0;
            double kontostand = 0;


            Console.WriteLine("Zinsrechner\n\n");

            Console.WriteLine("Bitte geben Sie Ihr Kapital ein");
            kapital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihren Zinssatz ein");
            zinssatz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Anlagedauer ein");
            jahre = Convert.ToInt32(Console.ReadKey());


            gewinn = kapital * zinssatz * jahre;

            kontostand = kapital + gewinn;
            Console.WriteLine(" Ihr Gewinn ist:{0}", gewinn);


            Console.WriteLine(" Ihr Kontostand ist:{0}", kontostand);




        }
    }
}
