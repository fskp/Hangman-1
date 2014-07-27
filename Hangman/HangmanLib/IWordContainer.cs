namespace HangmanLib
{
	public interface IWordsContainer
	{
		void AddWord(string word);

        string GetWord(int index);

        int Count();
	}
}
