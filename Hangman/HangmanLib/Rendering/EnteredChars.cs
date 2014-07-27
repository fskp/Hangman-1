namespace HangmanLib.Rendering
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EnteredChars : VisualObject
    {
        private IList<char> enteredChars;
        
        public EnteredChars(int x, int y, ICollection<char> enteredChars)
            : base(x, y)
        {
            this.enteredChars = new List<char>(enteredChars);
        }

        protected override char[,] CreateBodyTemplate()
        {
            var enteredLetters = string.Join(", ", this.enteredChars);
            var message = "Entered letters: " + enteredLetters;
            var result = new char[1, message.Length];
            
            for(int i = 0; i < message.Length; i++)
            {
                result[0, i] = message[i];
            }

            return result;
        }
    }
}
