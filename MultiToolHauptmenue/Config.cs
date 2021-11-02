using System;
using MultiToolKlassenBibliothek;

namespace MultiToolHauptmenue
{
    class Config
    {
        static void Main()
        {
            //Die Größe des Konsolenfensters wird festgelegt(Höhe,Breite).
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //Aufruf des Hauptmenüs.
            MultiToolKlassenBibliothek.Hauptmenue.HauptmenueAufruf();

        }
    }
}
