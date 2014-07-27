using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public class ConsoleReader : IReader
	{
        public ConsoleReader()
        {

        }

        public char ReadInput()
        {
            Console.SetCursorPosition(3, 20);
            var input = Console.ReadLine();
            return input[0];
        }
    }
}
