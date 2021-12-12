using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ITMultiToolKlassenBibliothek
{
    class Feature9
    {
        public static void Feature9Funcion1()
        {
            string wiederholen;
            do
            {


                int auswahl1, auswahl2;

                do
                {
                    Console.WriteLine(" Bitte Wählen Sie Ihr Zahlensystem aus welchem Sie umwandeln möchten\n");
                    Console.WriteLine("\t1 - Hexadezimal\n");
                    Console.WriteLine("\t2 - Dezimal\n");
                    Console.WriteLine("\t3 - Oktal\n");
                    Console.WriteLine("\t4 - Binar\n");

                    auswahl1 = Convert.ToInt32(Console.ReadLine());
                    if (auswahl1 <= 0 || auswahl1 > 4)
                        Console.WriteLine("Fehleingabe!!");

                } while (auswahl1 <= 0 || auswahl1 > 4);                                    //Hab das UND zu Oder gemacht da ja nicht beide Bedingungen erfüllt sein müssen damit die Schleife wiederholt wird.



                do
                {
                    Console.WriteLine(" Bitte Wählen Sie Ihr Zahlensystem aus, in das umgewandelt werden soll\n");
                    Console.WriteLine("\t1 - Hexadezimal\n");
                    Console.WriteLine("\t2 - Dezimal\n");
                    Console.WriteLine("\t3 - Oktal\n");
                    Console.WriteLine("\t4 - Binar\n");

                    auswahl2 = Convert.ToInt32(Console.ReadLine());
                    if (auswahl2 <= 0 || auswahl2 > 4 || auswahl2 == auswahl1)              //Hier muss 'auswahl2' geprüft werden.
                        Console.WriteLine("Fehleingabe!!");

                } while (auswahl2 <= 0 || auswahl2 > 4 || auswahl2 == auswahl1);

                //Gesamte Konsole
                Console.Clear();




                //Aufruf einer Funktion die in die unterschiedlichen Zahlensysteme umrechnet
                ZahlensystemBackend(auswahl1,auswahl2);

                


                //Frage ob wiederholt werden soll
                Console.WriteLine("Mächten Sie das Programm wiederholen?(j/n)");
                wiederholen=Console.ReadLine().ToLower();

            } while (wiederholen=="j");
        }



        #region Backend


        private static void ZahlensystemBackend(int a1,int a2)
        {
            //Ein Array um die Kürzel dynamisch anzusteuern
            string[] z_systeme = { "HEX", "DEZ", "OKT", "BIN" };

            //Ein Indikator für eine nicht erfolgreiche Umwandlung
            bool trypassout;

            //Die Eingabe des Umwandlungswertes
            string s_eingabe1;





            do
            {

                
                Console.WriteLine("{0}->{1}", z_systeme[a1-1], z_systeme[a2-1]);
                Console.WriteLine("Verwenden Sie keine Trennzeichen");
                Console.Write("Geben Sie den {0} Wert ein:", z_systeme[a1-1]);
                s_eingabe1=Console.ReadLine();

                //Es gibt hier keinen Rückgabewert da in der Methode das Ergebnis ausgegeben wird
                BedingungPrüfen(a1, a2, s_eingabe1, out trypassout);


                //Wenn die Umwandlung nicht funktioniert, wird die schleife wiederholt
            } while (trypassout == false);


        }

        
        private static void BedingungPrüfen(int a1,int a2,string s_eingabe, out bool trypassout)
        {
            string[] z_systeme = { "HEX", "DEZ", "OKT", "BIN" };
            trypassout = true;

            switch (a1)
            {
                case 1:

                    //Dieser Teil wird versucht.
                    try
                    {
                        //Die Eingabe(string) wird in ein Integer umgewandelt.
                        int val_dec = int.Parse(s_eingabe, NumberStyles.HexNumber);
                        int val_okt = ToOctal(val_dec);



                        //Gibt HEX->DEC aus wenn die zweite Auswahl 2 ist
                        if (a2 == 2)
                            Console.WriteLine("{0} in {1}  = {2} in {3}.", s_eingabe, z_systeme[a1 - 1], val_dec, z_systeme[a2 - 1]);
                        //Gibt HEX->OKT aus wenn die zweite Auswahl 3 ist
                        if (a2 == 3)
                            Console.WriteLine("{0} in {1}  = {2} in {3}.", s_eingabe, z_systeme[a1 - 1], val_okt, z_systeme[a2 - 1]);
                        //Gibt HEX->BIN aus wenn die zweite Auswahl 4 ist
                        if (a2 == 4)
                            Console.WriteLine("{0} in {1}  = {2} in {3}.", s_eingabe, z_systeme[a1 - 1], Convert.ToString(val_dec, 2), z_systeme[a2 - 1]);


                        Console.ReadKey();
                    }
                    //Wenn 'try' einen Error verursacht, wird 'catch' ausgeführt
                    catch (Exception) //Gibt an welche Errortypen abgefangen werden
                    {
                        Console.WriteLine("Eingabe im falschen Format.");
                        Console.ReadKey();
                        
                        trypassout = false;
                    }

                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;
                    
            }
            Console.Clear();
        }
        //Diese Methode nimmt einen 'int' Wert(Dezimal) auf und gibt einen 'int' Wert(Oktal) zurück
        public static int ToOctal(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x % 8 + 10 * ToOctal(x / 8);
        }
        #endregion

    }
}
