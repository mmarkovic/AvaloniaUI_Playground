namespace Sudoku.Core
{
    public sealed class GivenSquare : Square
    {
        public GivenSquare(byte givenValue)
        {
            Value = givenValue;
        }

        public override byte? Value { get; }
    }
}