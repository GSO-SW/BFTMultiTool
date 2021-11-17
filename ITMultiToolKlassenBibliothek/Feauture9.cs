using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMultiToolKlassenBibliothek
{
    class Feauture9
    {
        public static void Feature9Funcion1()
        {
            Console.WriteLine("Feature9 SubSubMenue");
        }

        public class cFromInZahlenSystem
        {

            private cFromInZahlenSystem() { }

            // Eigenschaften
            public enum ZAHLENSYSTEM { BINAER = 2, OKTAL = 8, DEZIMAL = 10, HEXA = 16 };


            
            public static object[] ComboBoxListe = new object[] {
             "von DEC in BIN"   ,
             "von DEC in OCT"  ,
             "von DEC in HEX"    ,
             "-----------------------" ,
             "von BIN in DEC"   ,
             "von OCT in DEC"   ,
             "von HEX in DEC"   ,
             "-----------------------" ,
             "von BIN in OCT"  ,
             "von HEX in OCT"   ,
             "-----------------------" ,
             "von BIN in HEX"   ,
             "von OCT in HEX"  ,
             "-----------------------" ,
             "von OCT in BIN"  ,
             "von HEX in BIN"  ,
             "-----------------------"
        };

            private static object VON_ZAHL
            {
                get;
                set;
            }
            public static object IN_ZAHL_ERGEBNIS
            {
                get;
                private set;
            }

            private static int VON_ZAHLENSYSTEM
            {
                get;
                set;
            }
            private static int IN_ZAHLENSYSTEM
            {
                get;
                set;
            }

            
            public static void umrechnenZahl(object vonZahl, ZAHLENSYSTEM von_Zahlensystem, ZAHLENSYSTEM in_Zahlensystem)
            {

                if (vonZahl.ToString().Length <= 0)
                    throw new FormatException("Fehler 1a:   bitte eine Zahl eingeben ");


                VON_ZAHL = vonZahl;

                VON_ZAHLENSYSTEM = von_Zahlensystem.GetHashCode();
                IN_ZAHLENSYSTEM = in_Zahlensystem.GetHashCode();

                berechnung();


            }

            public static void umrechnenZahl(object vonZahl, int von_Zahlensystem, int in_Zahlensystem)
            {

                if (vonZahl.ToString().Length <= 0)
                    throw new FormatException("Fehler 2a:   bitte eine Zahl eingeben ");


                VON_ZAHL = vonZahl;
                if (!((von_Zahlensystem == ZAHLENSYSTEM.BINAER.GetHashCode()) || (von_Zahlensystem == ZAHLENSYSTEM.DEZIMAL.GetHashCode()) || (von_Zahlensystem == ZAHLENSYSTEM.HEXA.GetHashCode()) || (von_Zahlensystem == ZAHLENSYSTEM.OKTAL.GetHashCode())))
                    throw new FormatException("Fehler 2b:   bitte  von_welchem_ZahlSystem  eingeben  ->(2,8,10,16)");

                VON_ZAHLENSYSTEM = von_Zahlensystem;

                if (!((in_Zahlensystem == ZAHLENSYSTEM.BINAER.GetHashCode()) || (in_Zahlensystem == ZAHLENSYSTEM.DEZIMAL.GetHashCode()) || (in_Zahlensystem == ZAHLENSYSTEM.HEXA.GetHashCode()) || (in_Zahlensystem == ZAHLENSYSTEM.OKTAL.GetHashCode())))
                    throw new FormatException("Fehler 2c:   bitte  in_welches_neue_ZahlSystem  eingeben   ->(2,8,10,16)");
                IN_ZAHLENSYSTEM = in_Zahlensystem;

                berechnung();


            }


            private static void berechnung()
            {
                // von Binaer....
                if (VON_ZAHLENSYSTEM == 2)
                {
                    switch (IN_ZAHLENSYSTEM)
                    {
                        case 2:
                            IN_ZAHL_ERGEBNIS = (object)(Convert.ToString((Convert.ToUInt32(VON_ZAHL)), 2).PadLeft(32, '0'));
                            break;
                        case 8:
                            BinToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToOct();
                            break;
                        case 10:
                            BinToDec();
                            break;
                        case 16:
                            BinToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToHex();
                            break;
                        default:
                            break;
                    }
                }

                // von Octal....
                if (VON_ZAHLENSYSTEM == 8)
                {
                    switch (IN_ZAHLENSYSTEM)
                    {
                        case 2:
                            OctToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToBin();
                            break;
                        case 8:
                            IN_ZAHL_ERGEBNIS = VON_ZAHL;
                            break;
                        case 10:
                            OctToDec();
                            break;
                        case 16:
                            OctToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToHex();
                            break;
                        default:
                            break;
                    }
                }

                //von DEC........
                if (VON_ZAHLENSYSTEM == 10)
                {
                    switch (IN_ZAHLENSYSTEM)
                    {
                        case 2:
                            DecToBin();
                            break;
                        case 8:
                            DecToOct();
                            break;
                        case 10:
                            IN_ZAHL_ERGEBNIS = VON_ZAHL;
                            break;
                        case 16:
                            DecToHex();
                            break;
                        default:
                            break;
                    }
                }


                //von HEX........
                if (VON_ZAHLENSYSTEM == 16)
                {
                    switch (IN_ZAHLENSYSTEM)
                    {
                        case 2:
                            HexToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToBin();
                            break;
                        case 8:
                            HexToDec();
                            VON_ZAHL = IN_ZAHL_ERGEBNIS;
                            DecToOct();
                            break;
                        case 10:
                            HexToDec();
                            break;
                        case 16:
                            IN_ZAHL_ERGEBNIS = VON_ZAHL;
                            break;
                        default:
                            break;
                    }
                }



            }


            // Dezimal in Binaer
            private static void DecToBin()
            {

                IN_ZAHL_ERGEBNIS = (object)(Convert.ToString((Convert.ToUInt32(VON_ZAHL)), 2).PadLeft(32, '0'));

            }
            private static void DecToOct()
            {

                IN_ZAHL_ERGEBNIS = (object)(Convert.ToString((Convert.ToUInt32(VON_ZAHL)), 8).PadLeft(32, '0'));

            }
            // Dezimal nach Hexadezimal
            private static void DecToHex()
            {
                IN_ZAHL_ERGEBNIS = (object)(string.Format("{0:x}", Convert.ToInt16(Convert.ToString(VON_ZAHL))));
            }



            // Binaer in dezimal
            private static void BinToDec()
            {
                IN_ZAHL_ERGEBNIS = (object)(Convert.ToUInt64((string)VON_ZAHL, 2));

            }
            // Octal in dezimal
            private static void OctToDec()
            {
                IN_ZAHL_ERGEBNIS = (object)(Convert.ToUInt64((string)VON_ZAHL, 8));

            }
            // Hexadezimal nach Dezimal
            private static void HexToDec()
            {
               
                IN_ZAHL_ERGEBNIS = (object)(Convert.ToInt64((string)VON_ZAHL, 16));


            }

           
            public static string auswerten_comboBox_SelectedIndexChanged(int index, object value)
            {
                string s = null;

                
                try
                {

                    switch (index)
                    {
                        case 0:

                            umrechnenZahl((object)value, ZAHLENSYSTEM.DEZIMAL, ZAHLENSYSTEM.BINAER);
                            break;
                        case 1:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.DEZIMAL, ZAHLENSYSTEM.OKTAL);
                            break;
                        case 2:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.DEZIMAL, ZAHLENSYSTEM.HEXA);
                            break;
                        case 4:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.BINAER, ZAHLENSYSTEM.DEZIMAL);
                            break;
                        case 5:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.OKTAL, ZAHLENSYSTEM.DEZIMAL);
                            break;
                        case 6:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.HEXA, ZAHLENSYSTEM.DEZIMAL);
                            break;
                        case 8:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.BINAER, ZAHLENSYSTEM.OKTAL);
                            break;
                        case 9:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.HEXA, ZAHLENSYSTEM.OKTAL);
                            break;
                        case 11:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.BINAER, ZAHLENSYSTEM.HEXA);
                            break;
                        case 12:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.OKTAL, ZAHLENSYSTEM.HEXA);
                            break;
                        case 14:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.OKTAL, ZAHLENSYSTEM.BINAER);
                            break;
                        case 15:
                            umrechnenZahl((object)value, ZAHLENSYSTEM.HEXA, ZAHLENSYSTEM.BINAER);
                            break;

                        default:

                            break;

                    }
                    s = Convert.ToString(IN_ZAHL_ERGEBNIS);



                    return s;
                }
                   finally
                { }


        }
        }

    }
}
