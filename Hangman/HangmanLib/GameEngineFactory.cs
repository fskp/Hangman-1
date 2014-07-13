using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public abstract class GameEngineFactory
	{
		public abstract IGameEngine CreateGameEngine(string[] words);
	}
}
