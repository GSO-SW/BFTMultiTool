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
                                  "welcher auf der Erdoberfläche der Erdbeschleunigung entspricht.Die Einheit der Gewichtskraft ist Newton[N].\n" +
                                  "\nErde Ortskraft:\t9,81[m/(s^2)] " +
                                  "\nMond Ortskraft:\t1,62[m/(s^2)]" +
                                  "\n\nDies ist die formel:\tF_g = m x g" +
                                  "\n\n\tF_g = Gewichtskraft" +
                                  "\n\tm= Masse" +
                                  "\n\tg= Ortsfaktor");
                Console.WriteLine("\num ins Submenue zu kommen, geben Sie Subexit in die eingabe");
                string str_Gewicht = Console.ReadLine();

                if(str_Gewicht=="Subexit")
                {
                    Subexit = true;
                }
                else
                {
                    
                            
                            
                            
                 
                }


                double dou_Gewicht = Convert.ToDouble(str_Gewicht);

            }
            while (Subexit==false);
        }

    }
}