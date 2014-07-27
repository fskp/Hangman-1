using HangmanLib.Rendering;
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

            IReader reader = new ConsoleReader();

            IMessageProvider messageProvider = new DefaultMessageProvider();
            Renderer renderer = new ConsoleRenderer(20, 80);

            IParser parser = new DefaultParser();

            IScoreboard scoreBoard = new DefaultScoreboard();

            var resultGameEngine = new GameEngine(reader, renderer, parser, scoreBoard);

			resultGameEngine.AddWord("pesho");
			return resultGameEngine;
		}
	}
}
