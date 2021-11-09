using System;
using MultiToolKlassenBibliothek;

namespace MultiTool
{
    class Config
    {
        static void Main()
        {
            //Die Größe des Konsolenfensters wird an den Bildschirm angepasst.
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            //Schriftfarbe wird auf Grün gesetzt.
            Console.ForegroundColor = ConsoleColor.Green;

            //Der Schrifthintergrund kann geändert werden.
            //Console.BackgroundColor = ConsoleColor.DarkRed;

            //Aufruf des Hauptmenüs.
            MultiToolKlassenBibliothek.Hauptmenue.HauptmenueAufruf();

        }
    }
}
