using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	public class DefaultGameEngineFactory : GameEngineFactory
	{
		public override IGameEngine CreateGameEngine(string[] words)
		{
			//TODO: Implement
			var resultGameEngine = new GameEngine();

			resultGameEngine.AddWord("pesho");
			return resultGameEngine;
		}
	}
}
