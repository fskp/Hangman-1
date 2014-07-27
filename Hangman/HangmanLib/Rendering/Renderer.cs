namespace HangmanLib.Rendering
{
    using System;

	public abstract class Renderer
	{
        protected int height;
        protected int width;
        protected IMessageProvider messageRenderer;
        protected char[,] screen;

        public Renderer(int height, int width)
        {
            this.height = height;
            this.width = width;
            this.screen = new char[this.height, this.width];
        }

		public Renderer(int height, int width, IMessageProvider messageProvider)
            : this(height, width)
		{
			this.messageRenderer = messageProvider;
		}

        public void AddVisualObject(VisualObject obj)
        {
            var topLeft = obj.TopLeft();
            var body = obj.GetBody();

            for(int i = 0; i < body.GetLength(0); i++)
            {
                for(int j = 0; j < body.GetLength(1); j++)
                {
                    this.screen[i + topLeft.X, j + topLeft.Y] = body[i, j];
                }
            }
        }

        public void RemoveVisualObject(VisualObject obj)
        {
            var topLeft = obj.TopLeft();
            var body = obj.GetBody();

            for (int i = 0; i < body.GetLength(0); i++)
            {
                for (int j = 0; j < body.GetLength(1); j++)
                {
                    this.screen[i + topLeft.X, j + topLeft.Y] = ' ';
                }
            }
        }

        public abstract void RenderMessage(MessageTypes messageType, params object[] parameters);

        public abstract void RenderAll();

        public abstract void Clear();
        // TODO: add additional functionality
	}
}
