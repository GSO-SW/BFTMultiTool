using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHMultiToolKlassenBibliothek
{
    class Feature6
    {
        public static void Feature6Funcion1()
        {
            do
            {
                Console.WriteLine("Schwerkraft");
                Console.WriteLine("Hallo liebe leute, im folgenden Text werdet Ihr erfahren wie Ihr die Schwerkraft auf der Erde und auf dem Mond berechnet könnt\n" +
                    "Die Gewichtskraft, oder auch Schwerkraft genannt, ist die Kraft auf einen Körper, welche durch die Wirkung einer Gravitation erzeugt wird. Du kannst sie mit dem Produkt aus" +
                    " Masse m und Erdbeschleunigung g berechnen.\nJe größer dabei die Masse des Körpers ist, umso größer ist auch seine Gewichtskraft.Die Größe der Kraft hängt ebenso vom Ort ab, an " +
                    "dem sich der betreffende Körper befindet.\nDies wird durch den Ortsfaktor g ausgedrückt, welcher auf der Erdoberfläche der Erdbeschleunigung entspricht.Die Einheit der " +
                    "Gewichtskraft ist Newton[N].\n\nErde Ortskraft:9,81[m/(s^2)] und Mond Ortskraft 1,62[m/(s^2)]\nDies ist die formel:F_g = m x g\nF_g = Gewichtskraft\nm= Masse\ng= Ortsfaktor");
                Console.WriteLine("\num ins Submenue zu kommen, geben Sie Subexit in die eingabe");
                String str_Gewicht = Console.ReadLine();
            }
            while (true);
        }

    }
}