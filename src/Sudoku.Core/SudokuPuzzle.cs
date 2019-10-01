namespace Sudoku.Core
{
    using System;
    using System.Linq;
    using System.Text;

    public sealed class SudokuPuzzle
    {
        private readonly Square[,] squares = new Square[10, 10];

        public SudokuPuzzle()
        {
            this.InitializePuzzle();
        }

        public byte? this[int rowNr, int columnNr]
        {
            get
            {
                return this.squares[rowNr - 1, columnNr - 1].Value;
            }

            set
            {
                int rowIndex = rowNr - 1;
                int columnIndex = columnNr - 1;

                if (value.HasValue)
                {
                    this.squares[rowIndex, columnIndex] = new GivenSquare(value.Value);
                }
                else
                {
                    this.squares[rowIndex, columnIndex] = new SquareToSolve();
                }
            }
        }

        private void InitializePuzzle()
        {
            for (int rowIndex = 0; rowIndex < 10; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < 10; columnIndex++)
                {
                    this[rowIndex + 1, columnIndex + 1] = null;
                }
            }
        }

        public static SudokuPuzzle Parse(string puzzleAsString)
        {
            const char placeHolderChar = '.';

            var puzzle = new SudokuPuzzle();

            char[] allowedCharacters = { placeHolderChar, '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var allCharacters = puzzleAsString.ToCharArray();
            var onlyValidCharacters = allCharacters.Where(c => allowedCharacters.Contains(c)).ToArray();

            int rowIndex = 0;
            int columnIndex = 0;

            for (int i = 0; i < onlyValidCharacters.Length; i++)
            {
                var character = onlyValidCharacters[i];
                if (allowedCharacters.Contains(character))
                {
                    if (character != placeHolderChar)
                    {
                        byte value = (byte)(character - 48);
                        puzzle.SetValue(rowIndex + 1, columnIndex + 1, value);
                    }

                    columnIndex = (columnIndex + 1) % 9;
                    if (columnIndex == 0)
                    {
                        rowIndex += 1;
                    }
                }
            }

            return puzzle;
        }

        public void SetValue(int rowNr, int columnNr, byte value)
        {
            this.squares[rowNr - 1, columnNr - 1] = new GivenSquare(value);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int columnNr = 1; columnNr <= 9; columnNr++)
            {
                for (int rowNr = 1; rowNr <= 9; rowNr++)
                {
                    byte? squareValue = this[rowNr, columnNr];
                    sb.Append(squareValue);
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}