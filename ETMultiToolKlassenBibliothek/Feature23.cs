using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace ETMultiToolKlassenBibliothek
{
    class Feature23
    {
        public static void Feature23Funcion1()
        {
            Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                   "                              >>> Berechnung von Wiederstand <<<\n" +
                                   "------------------------------------------------------------------------------------\n\n");
            string Ausw1;
            Console.WriteLine("Wählen Sie eine der folgenden Themenbereiche:\n");
            Console.WriteLine("\t1 - Wiederstand");
            Console.WriteLine("\t2 - Spule");
            Console.WriteLine("\t3 - Kondensator");
            Console.Write("Eingabe:");
            Ausw1 = Console.ReadLine();

            switch (Ausw1)
            {

                case "1":
                    Console.Clear();
                    Widerstand();
                    break;

                case "2":
                    Console.Clear();


                    break;

                case "3":
                    Console.Clear();


                    break;


            }

        }
        public static void Widerstand()

        {
            int Widerstand1, Widerstand2;
            Console.WriteLine("Wiederstandsberechnung eines Leiters");

            Console.WriteLine("Formel des Wiederstands:   R=p*l/A");

            Console.WriteLine(
            "(S) Silber:. . . . . . . . .{0,10}\n" +
            "(k) Kupfer:. . . . . . . . .{1,10}\n" +
            "(G) Gold:. . . . . . . . . .{2,10}\n" +
            "(A) Aluminium:. . . . . . . {3,10}\n" +
            "(Z) Zink:. . . . . . . . . .{4,10}\n" +
            "(M) Messing:. . . . . . . . {5,10}\n" +
            "(E) Eisen: . . . . . . . . .{6,10}\n" +
            "(P) Platin:. . . . . . . . .{7,10}\n" +
            "(Zi) Zinn: . . . . . . . . .{8,10}\n" +
            "(B) Blei:. . . . . . . . . .{9,10}\n" +
            "(Ko) Kohle:. . . . . . . . .{10,10}\n",
            0.016, 0.018, 0.022, 0.028, 0.06, 0.07, 0.1, 0.106, 0.11, 0.208, 66.667);

            do
            {
                Console.WriteLine("Bitte wählen sie ihr Material");
                Console.ReadLine();
                _ = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bitte geben sie ihre Länge an");
                Console.ReadLine();
                Double Wiederstand1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Geben sie die Querschnittfläche an");
                Console.ReadLine();

                Double Wiederstand2 = Convert.ToDouble(Console.ReadLine());


            } while (default);





        }

        public static void Kondensator()
        {



        }

        public static void Spule()
        {



        }

    }
}
