namespace Sudoku.Core
{
    public static class PuzzleProvider
    {
        public static SudokuPuzzle SamplePuzzle1
        {
            get
            {
                return SudokuPuzzle.Parse(
                    @"..6 ... 295
                      3.. .5. ...
                      .2. ..1 .8.

                      ... 6.5 7.8
                      4.1 .9. 3.6
                      8.5 3.4 ...

                      .5. 8.. .1.
                      ... .2. ..7
                      298 ... 5..");
            }
        }
    }
}
