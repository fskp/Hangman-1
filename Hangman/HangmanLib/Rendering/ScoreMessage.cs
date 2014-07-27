namespace HangmanLib.Rendering
{
    using System;

    public class ScoreMessage : VisualObject
    {
        private int score;

        public ScoreMessage(int x, int y, int score)
            : base(x, y)
        {
            this.score = score;
        }

        protected override char[,] CreateBodyTemplate()
        {
            var message = string.Format("Score: {0}", this.score);
            var result = new char[1, message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                result[0, i] = message[i];
            }

            return result;
        }
    }
}
