namespace HangmanLib.Common
{
    using System;

    

    public struct Coordinates
    {
        private int coordX;
        private int coordY;

        public Coordinates(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.coordX;
            }

            private set
            {
                this.coordX = value;
            }
        }

        public int Y
        {
            get
            {
                return this.coordY;
            }

            private set
            {
                this.coordY = value;
            }
        }
    }
}
