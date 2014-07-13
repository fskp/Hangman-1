using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public class DefaultMessageProvider : IMessageProvider
	{
		public string GetGreetinsMessage()
		{
			return "Greetings";
		}

		public string GetLostMessage(string score)
		{
			return string.Format("You lost with {0} score", score);
		}
	}
}
