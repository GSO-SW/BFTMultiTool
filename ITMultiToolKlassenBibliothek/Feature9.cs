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

            do
            {
                bool fehlermeldung;

                int auswahl1, auswahl2;

                do
                {
                    Console.WriteLine(" Bitte Wählen Sie Ihr Zahlensystem aus welchem Sie umwandeln möchten\n");
                    Console.WriteLine("\t1 - Hexadezimal\n");
                    Console.WriteLine("\t2 - Dezimal\n");
                    Console.WriteLine("\t3 - Oktal\n");
                    Console.WriteLine("\t4 - Binar\n");

                    auswahl1 = Convert.ToInt32(Console.ReadLine());
                    if (auswahl1 <= 0 && auswahl1 > 4)
                        Console.WriteLine("Fehleingabe!!");

                } while (auswahl1 <= 0 && auswahl1 > 4);



                do
                {
                    Console.WriteLine(" Bitte Wählen Sie Ihr Zahlensystem aus welchem Sie umwandeln möchten\n");
                    Console.WriteLine("\t1 - Hexadezimal\n");
                    Console.WriteLine("\t2 - Dezimal\n");
                    Console.WriteLine("\t3 - Oktal\n");
                    Console.WriteLine("\t4 - Binar\n");

                    auswahl2 = Convert.ToInt32(Console.ReadLine());
                    if (auswahl1 <= 0 && auswahl1 > 4 && auswahl2 == auswahl1)
                        Console.WriteLine("Fehleingabe!!");

                } while (auswahl1 <= 0 && auswahl1 > 4 && auswahl2 == auswahl1);


                string zahlensystem1 = Console.ReadLine();


                if (auswahl2 == 1);
                    int dezimal = hexadezimal;
                    string dezimal = string.Empty;

                while (dezimal > 0)
                {
                    hexadezimal = dezimal % 16;

                    if (hexadezimal < 10)
                        hexadezimal = hexadezimal.Insert(0, Convert.ToChar(hexadezimal + 48).ToString());
                    else
                        hexadezimal = hexadezimal.Insert(0, Convert.ToChar(hexadezimal + 55).ToString());

                    dezimal /= 16;
                }











            } while ();

          



        }
    }
}
