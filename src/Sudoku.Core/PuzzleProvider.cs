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
        public static SudokuPuzzle SamplePuzzle1Solution
        {
            get
            {
                return SudokuPuzzle.Parse(
                    @"146 783 295
                      389 452 671
                      527 961 483

                      932 615 748
                      471 298 356
                      865 374 129

                      753 846 912
                      614 529 837
                      298 137 564");
            }
        }
    }
}
