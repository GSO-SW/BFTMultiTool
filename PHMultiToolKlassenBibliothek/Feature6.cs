using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;


namespace PHMultiToolKlassenBibliothek
{
    class Feature6
    {
        public static void Feature6Funcion1()
        {
            bool Subexit = false;
            bool Errorcode = false;



            do
            {
                Console.WriteLine
                    (FiggleFonts.Slant.Render("BFTMultiTool"));
                Console.WriteLine("------------------------------------------------------------------------------------\n" +
                                  "                              >>> Schwerkraft <<<\n" +
                                  "------------------------------------------------------------------------------------\n\n");

                Console.WriteLine("Hallo liebe leute, im folgenden Text werdet Ihr erfahren wie Ihr die Schwerkraft auf der Erde und auf dem Mond berechnet könnt\n" +
                                  "Die Gewichtskraft, oder auch Schwerkraft genannt, ist die Kraft auf einen Körper, welche durch die Wirkung einer Gravitation erzeugt wird.\n" +
                                  "Du kannst sie mit dem Produkt aus Masse m und Erdbeschleunigung g berechnen. Je größer dabei die Masse des Körpers ist, umso größer ist auch\n" +
                                  "seine Gewichtskraft.Die Größe der Kraft hängt ebenso vom Ort ab, an dem sich der betreffende Körper befindet.Dies wird durch den Ortsfaktor g ausgedrückt,\n" +
                                  "welcher auf der Erdoberfläche der Erdbeschleunigung entspricht.Die Einheit der Gewichtskraft ist Newton[N].\nUm Ihr Körpergewicht auf dem Mond zuberechnen, rechnen Sie Kg x 1/6\n" +
                                  "\nErde Ortskraft:\t9,81[m/(s^2)] " +
                                  "\nMond Ortskraft:\t1,62[m/(s^2)]" +
                                  "\n\nDies ist die formel:\tF_g = m x g" +
                                  "\n\n\tF_g = Gewichtskraft" +
                                  "\n\tm= Masse" +
                                  "\n\tg= Ortsfaktor\n\n");
                Console.WriteLine("\nGeben Sie nun Ihr Gewicht ein. Wenn Sie ins Submenü zurück wollen, geben Sie Subexit in die Eingabe ein.");
                string str_Gewicht = Console.ReadLine();

                if (str_Gewicht == "Subexit")
                {

                }
                else
                {
                    try
                    {
                        double doub_Gewicht = Convert.ToDouble(str_Gewicht);


                        Errorcode = false;
                        if (doub_Gewicht >= 0)
                        {
                            Console.WriteLine("Berechnung:\n");
                            double ausgabe1;
                            double ausgabe2;
                            ausgabe1 = doub_Gewicht * 9.81;
                            ausgabe2 = doub_Gewicht * 1.62;
                            Console.WriteLine($"Ihre Berechnung auf der Erde lautet: {doub_Gewicht} * 9.81.");
                            Console.WriteLine($"Somit ist ihre Schwerkraft auf der Erde {ausgabe1}.\n");
                            Console.WriteLine($"Ihre Berechnung auf dem Mond lautet: {doub_Gewicht} * 1.62");
                            Console.WriteLine($"Somit ist ihre Schwerkraft auf dem Mond {ausgabe2}.\n");
                            Console.WriteLine($"Ihr Körpergewicht auf dem Mond beträgt {doub_Gewicht / 6} Kg.\n\n");
                            Console.WriteLine("Sobald Sie fertig sind, drücken Sie eine beliebige Taste um ins Hauptmenü zu gelangen.");
                            Console.ReadKey();
                        }
                    }
                    catch (Exception e)
                    {
                        Errorcode = true;
                        Console.WriteLine("Fehler, geben Sie eine Zahl größer als 0 ein. Drücken Sie eine beliebige Taste, um die Rechnung erneut einzugeben!");
                        Console.ReadKey();
                    }


                }





                Console.Clear();

            }
            while (Subexit == false & Errorcode == true);
        }

    }
}