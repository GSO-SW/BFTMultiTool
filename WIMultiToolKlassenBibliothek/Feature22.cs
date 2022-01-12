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

            string str_fixkosten;
            double doub_fixkosten;

            string str_Variablekosten;
            double doub_Variablekosten;

            string str_PpP;
            double doub_PpP;


            bool tryparseout;

            string str_wiederholen;
            bool bool_wiederholen;

            do
            {
                Console.WriteLine("Fix- und Variablekosten");

                do
                {

                    Console.WriteLine("Geben sie Ihre Fixkosten ein");
                    str_fixkosten = Console.ReadLine();
                    tryparseout = double.TryParse(str_fixkosten, out doub_fixkosten);

                } while (tryparseout == false);

                do
                {

                    Console.WriteLine("Geben sie Ihre Variable Kosten ein");
                    str_Variablekosten = Console.ReadLine();
                    tryparseout = double.TryParse(str_Variablekosten, out doub_Variablekosten);

                } while (tryparseout == false);

                do
                {

                    Console.WriteLine("Geben sie bitte Preis pro Stück ein");
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
                    tryparseout = bool.TryParse(str_wiederholen, out bool_wiederholen);

                } while (tryparseout == false);



                Console.Clear();



            } while (bool_wiederholen==true);















        }
    }
}
