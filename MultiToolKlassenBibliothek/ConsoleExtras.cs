using System;

namespace MultiToolKlassenBibliothek
{
    public class ConsoleExtras
    {
        public static void ClearCurrentConsoleLine(int from, int to)
        {
            for (int i = to; i >= from; i--)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(new string(' ', Console.WindowWidth));
            }

            Console.SetCursorPosition(0, from);
        }
    }
}
