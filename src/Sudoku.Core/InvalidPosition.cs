namespace Sudoku.Core
{
    public sealed class InvalidPosition
    {
        public int RowNumber { get; }

        public int ColumnNumber { get; }

        public InvalidPosition(int rowNumber, int columnNumber)
        {
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
        }
    }
}