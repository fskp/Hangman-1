using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public class DefaultMessageProvider : IMessageProvider
	{
        private Dictionary<MessageTypes, string> messageFormatersList;

        public DefaultMessageProvider()
        {
            messageFormatersList.Add(MessageTypes.GreetingsMessage, "Welcome to “Hangman” game. Please try to guess my secret word.");
            // TODO: add all the messages in a similar manner
        }

        public string GetMessage(MessageTypes messageType, params object[] parameters)
        {
            if (!messageFormatersList.ContainsKey(messageType))
            {
                return "";
            }

            return String.Format(messageFormatersList[messageType], parameters);
        }
    }
}
