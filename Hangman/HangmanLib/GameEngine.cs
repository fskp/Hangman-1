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

        private ICollection<char> enteredLetters;

		public void Run()
		{
            int score = 13;
            var scoreMessage = new ScoreMessage(3, 3, score);

            var enteredCharsMessage = new EnteredChars(5, 3, this.enteredLetters);

            renderer.AddVisualObject(scoreMessage);
            renderer.AddVisualObject(enteredCharsMessage);

            while(true)
            {
                this.renderer.Clear();
                this.renderer.AddVisualObject(scoreMessage);
                this.renderer.AddVisualObject(enteredCharsMessage);
                this.renderer.RenderAll();
                this.renderer.RemoveVisualObject(scoreMessage);
                this.renderer.RemoveVisualObject(enteredCharsMessage);

                Console.SetCursorPosition(3, 23);
                Console.Write("Enter input: ");
                var input = this.reader.ReadInput();
                if(!this.enteredLetters.Contains(input))
                {
                    score++;
                    this.enteredLetters.Add(input);
                }

                
                
                enteredCharsMessage = new EnteredChars(5, 3, this.enteredLetters);

                
                scoreMessage = new ScoreMessage(3, 3, score);
            }
		}

        public GameEngine(IReader reader, Renderer renderer)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.enteredLetters = new HashSet<char>();
        }

		public GameEngine(IReader reader, Renderer renderer, IParser parser, IScoreboard scoreboard)
            : this(reader, renderer)
		{
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
