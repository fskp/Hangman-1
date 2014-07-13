using System;

class ScoreBoard
{
    private const int NumberOfScores = 5;
    private string[] scoreNames = new string[NumberOfScores];
    private int[] mistakesCollection = new int[NumberOfScores];
    private bool isEmpty;

    public ScoreBoard()
    {
        for (int i = 0; i < scoreNames.Length; i++)
        {
            scoreNames[i] = null;
            mistakesCollection[i] = int.MaxValue;
        }

        isEmpty = true;
    }

    public void Print()
    {
        if (isEmpty)
        {
            Console.WriteLine("Scoreboard is empty!");
        }
        else
        {
            Console.WriteLine("Scoreboard:");
            int i = 0;
            while (scoreNames[i] != null)
            {
                Console.WriteLine("{0}. {1} ---> {2} mistake(s)!", i + 1, scoreNames[i], mistakesCollection[i]);
                i++;
                if (i >= scoreNames.Length)
                {
                    break;
                }
            }
        }
    }

    public void AddNewScore(string nickName, int mistakes)
    {
        int indexToPutNewScore = FindIndexWhereToPutNewScore(mistakes);
        if (indexToPutNewScore == scoreNames.Length)
        {
            return;
        }
        else
        {
            MoveScoresDownByOnePosition(indexToPutNewScore);
            scoreNames[indexToPutNewScore] = nickName;
            mistakesCollection[indexToPutNewScore] = mistakes;
            isEmpty = false;
        }
    }

    private int FindIndexWhereToPutNewScore(int mistakes)
    {
        for (int i = 0; i < mistakesCollection.Length; i++)
        {
            if (mistakes < mistakesCollection[i])
            {
                return i;
            }
        }

        return scoreNames.Length;
    }

    private void MoveScoresDownByOnePosition(int startPosition)
    {
        for (int i = scoreNames.Length - 1; i > startPosition; i--)
        {
            scoreNames[i] = scoreNames[i - 1];
            mistakesCollection[i] = mistakesCollection[i - 1];
        }
    }

    public int GetWorstTopScore()
    {
        int worstTopScore = int.MaxValue;
        if (scoreNames[scoreNames.Length - 1] != null) 
        { 
            worstTopScore = mistakesCollection[scoreNames.Length - 1]; 
        }

        return worstTopScore;
    }

    public void ReSet()
    {
        for (int i = 0; i < scoreNames.Length; i++)
        {
            scoreNames[i] = null;
            mistakesCollection[i] = 0;
        }

        isEmpty = true;
    }
}
