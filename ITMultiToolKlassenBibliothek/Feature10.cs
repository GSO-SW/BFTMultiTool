using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMultiToolKlassenBibliothek
{
    class Feauture10
    {
        public static void Feature10Funcion1()
        {
            Console.WriteLine("Feature10 SubSubMenue");

            Console.WriteLine("");

            Console.WriteLine("Ermittler");



            Console.WriteLine(" Bitte geben Sie Name, Alter, Gewicht und Größe ein\n");
            
            Console.WriteLine("Bitte geben Sie Name ein\n");
            string name = Console.ReadLine();

            
            
            Console.WriteLine(" Bitte geben Sie Alter ein\n");
            string alter = Console.ReadLine();
            Console.WriteLine(" Bitte geben Sie  Gewicht ein\n");
            string gewicht = Console.ReadLine();
            Console.WriteLine(" Bitte geben Sie Größe ein\n");
            string größe = Console.ReadLine();



            Console.WriteLine("");

            Console.WriteLine(" [Die Person heißt {0} ist  {1} Jahre Alt , wiegt {2} und ist {3} hoch. ]",name,alter,gewicht,größe);

            Console.WriteLine("");

            
            Console.WriteLine("Programm wird beim  nächsten Tastendruck geschlossen!");

            System.Environment.Exit(-1);






        }
        
    }
}
