using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIMultiToolKlassenBibliothek
{
    class Feature22
    {
        public static void Feature22Funcion1()
        {
            Console.WriteLine("Fix- und Variablekosten");
            Console.Clear();
            Console.WriteLine("Geben sie Ihre Fixkosten ein");
            double Fk = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie Ihre Variable Kosten ein");
            double VK = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie bitte Preis pro Stück ein");
            double PpP = Convert.ToDouble(Console.ReadLine());
            double GpS = PpP - VK;
            Console.WriteLine("{0,-20}{1,20:F2}EUR", "Gewin pro Stück", GpS);
            double Vz = Fk / GpS;
            Console.WriteLine("{0,-20}{1,20:F2}", "Verkaufszahl", Vz);











        }
    }
}
