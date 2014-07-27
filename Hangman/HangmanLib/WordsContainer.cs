namespace HangmanLib
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

	public class WordsContainer : IWordsContainer
	{
		private ICollection<string> words;

		public WordsContainer()
		{
			words = new HashSet<string>();
		}
		
		public string GetWord(int index)
		{
            if(index >= this.words.Count)
            {
                throw new IndexOutOfRangeException("The index can not be greater or equal than the size of the collenction.");
            }

            return this.words.ElementAt(index);
		}

		public void AddWord(string word)
		{
            this.words.Add(word);
		}

        public int Count()
        {
            return this.words.Count;
        }
    }
}
