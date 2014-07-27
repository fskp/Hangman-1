namespace HangmanLib.Rendering
{
    using HangmanLib.Common;

    interface IRenderable
    {
        Coordinates TopLeft();

        char[,] GetBody();
    }
}
