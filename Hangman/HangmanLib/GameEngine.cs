using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangmanLib
{
	// Contains Chain of Responsibility
	// Contains Strategy
	public class GameEngine : IGameEngine, IWordsContainer
	{
		private IReader reader;
		private IRenderer renderer;
		private IParser parser;
		private IScoreboard scoreboard;
		private WordsContainer words;

		public void Run()
		{
			throw new NotImplementedException();
		}

		public GameEngine(IReader reader, IRenderer renderer, IParser parser, IScoreboard scoreboard)
		{
			this.reader = reader;
			this.renderer = renderer;
			this.parser = parser;
			this.scoreboard = scoreboard;
			this.words = new WordsContainer();
		}

		public void AddWord(string word)
		{
			this.words.AddWord(word);
		}
	}
}
