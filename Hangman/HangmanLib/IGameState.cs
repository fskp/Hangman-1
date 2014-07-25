using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanLib
{
    public interface IGameState
    {
        string WordToGuess { get; }
        char[] GuessedLetters { get; }
        int Mistakes { get; }
        bool HelpUsed { get; }

        // TODO: add methods for manipulating like reset, reveal letter...
    }
}
