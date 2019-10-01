namespace Sudoku.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PuzzleSolver
    {
        public SudokuPuzzle Solve(SudokuPuzzle puzzle)
        {
            return new SudokuPuzzle();
        }

        public ValidationResult Validate(SudokuPuzzle puzzle)
        {
            return PuzzleValidator.Validate(puzzle);
        }
    }
}