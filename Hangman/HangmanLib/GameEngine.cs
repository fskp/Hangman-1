using HangmanLib.Rendering;
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
		private Renderer renderer;
		private IParser parser;
		private IScoreboard scoreboard;
		private WordsContainer words;

		public void Run()
		{
            // TODO: add the main game logic here
			throw new NotImplementedException();
		}

		public GameEngine(IReader reader, Renderer renderer, IParser parser, IScoreboard scoreboard)
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


        public string GetWord(int index)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}
