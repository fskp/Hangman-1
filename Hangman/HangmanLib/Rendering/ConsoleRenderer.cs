namespace HangmanLib.Rendering
{
    using System;

    public class ConsoleRenderer : Renderer
    {
        public ConsoleRenderer(int height, int width)
            : base(height, width)
        {
        }


        // TODO: implement
        public override void RenderMessage(MessageTypes messageType, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public override void RenderAll()
        {
            // Avoids the jumping screen
            for(int i = 0; i < this.screen.GetLength(0) - 1; i++) 
            {
                for(int j = 0; j < this.screen.GetLength(1); j++)
                {
                    Console.Write(screen[i, j]);
                }
            }
        }

        public override void Clear()
        {
            Console.Clear();
        }
    }
}
