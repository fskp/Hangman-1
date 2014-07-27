namespace HangmanLib.Rendering
{
    using HangmanLib.Common;

    public abstract class VisualObject : IRenderable
    {
        private Coordinates topLeft;

        protected VisualObject(int coordX, int coordY)
        {
            topLeft = new Coordinates(coordX, coordY);
        }

        public Coordinates TopLeft()
        {
            return this.topLeft;
        }

        public char[,] GetBody()
        {
            return this.CreateBodyTemplate();
        }

        protected abstract char[,] CreateBodyTemplate();
    }
}