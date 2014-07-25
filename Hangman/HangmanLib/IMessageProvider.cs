using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public interface IMessageProvider
	{
        string GetMessage(MessageTypes messageType, params object[] parameters);
	}
}
