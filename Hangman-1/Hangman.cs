using System;

class Hangman
{
    private string wordToGuess;
    private char[] guessedLetters;
    private int mistakes;
    private bool helpUsed;
    private string[] words = {"computer", "programmer", "software", "debugger","compiler", "developer", "algorithm",
                                      "array", "method", "variable" };

    private Random randomGenerator = new Random();

    public Hangman() 
    {
        this.ReSet();
    }
    
    public void ReSet()
    {
        this.wordToGuess = IzberiRandomWord();
        this.guessedLetters = new char[wordToGuess.Length];
        
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        this.mistakes = 0;
        this.helpUsed = false;
    }

    public int Mistakes
    {
        get
        {
            return mistakes;
        }
    }

    public bool HelpUsed 
    {
        get 
        { 
            return helpUsed; 
        }
    }

    public char RevealALetter() 
    {
        char toReturnt = char.MinValue;
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            if (this.guessedLetters[i] == '_') 
            {
                this.guessedLetters[i] = this.wordToGuess[i];
                toReturnt = this.wordToGuess[i];
                this.helpUsed = true;
                break;
            }
        }

        return toReturnt;
    }

    public int NumberOccuranceOfLetter(char letter) 
    {
        int count = 0;
        for (int i = 0; i < this.wordToGuess.Length; i++)
        {
            if (this.wordToGuess[i] == letter) 
            {
                this.guessedLetters[i] = letter;
                count++;
            }
        }
    
        if (count == 0) 
        { 
            mistakes++; 
        }

        return count;
    }

    public void PrintCurrentProgress() 
    {
        Console.Write("The secret word is: ");
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            Console.Write("{0} ", guessedLetters[i]);
        }

        Console.WriteLine();
    }

    public bool isOver() 
    {
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            if (guessedLetters[i] == '_') 
            {
				return false;
            }
        }
    
        return true;
    }
    
    private string IzberiRandomWord()
    {
        int choice = randomGenerator.Next(words.Length);

        return words[choice];
    }
}
