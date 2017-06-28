using System;

namespace Trivia
{
    public class ConsoleDisplay : IDisplay
    {
        public void Display(string display)
        {
            Console.WriteLine( display);
        }

    }
}