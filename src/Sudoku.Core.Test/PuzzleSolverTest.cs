namespace Sudoku.Core.Test
{
    using FluentAssertions;
    using Xunit;

    public class PuzzleSolverTest
    {
        private readonly PuzzleSolver testee;

        public PuzzleSolverTest()
        {
            this.testee = new PuzzleSolver();
        }

        [Fact]
        public void ParsesPuzzle()
        {
            var puzzle = SudokuPuzzle.Parse(@"
534 678 912
672 195 348
198 342 567

859 761 423
426 853 791
713 924 856

961 537 284
287 419 635
345 286 179
");

            puzzle[1, 1].Should().Be(5);
            puzzle[1, 2].Should().Be(3);
            puzzle[1, 3].Should().Be(4);
            puzzle[1, 4].Should().Be(6);
            puzzle[1, 5].Should().Be(7);
            puzzle[1, 6].Should().Be(8);
            puzzle[1, 7].Should().Be(9);
            puzzle[1, 8].Should().Be(1);
            puzzle[1, 9].Should().Be(2);

            puzzle[2, 1].Should().Be(6);
            puzzle[2, 2].Should().Be(7);
            puzzle[2, 3].Should().Be(2);
            puzzle[2, 4].Should().Be(1);
            puzzle[2, 5].Should().Be(9);
            puzzle[2, 6].Should().Be(5);
            puzzle[2, 7].Should().Be(3);
            puzzle[2, 8].Should().Be(4);
            puzzle[2, 9].Should().Be(8);

            puzzle[3, 1].Should().Be(1);
            puzzle[3, 2].Should().Be(9);
            puzzle[3, 3].Should().Be(8);
            puzzle[3, 4].Should().Be(3);
            puzzle[3, 5].Should().Be(4);
            puzzle[3, 6].Should().Be(2);
            puzzle[3, 7].Should().Be(5);
            puzzle[3, 8].Should().Be(6);
            puzzle[3, 9].Should().Be(7);

            puzzle[4, 1].Should().Be(8);
            puzzle[4, 2].Should().Be(5);
            puzzle[4, 3].Should().Be(9);
            puzzle[4, 4].Should().Be(7);
            puzzle[4, 5].Should().Be(6);
            puzzle[4, 6].Should().Be(1);
            puzzle[4, 7].Should().Be(4);
            puzzle[4, 8].Should().Be(2);
            puzzle[4, 9].Should().Be(3);

            puzzle[5, 1].Should().Be(4);
            puzzle[5, 2].Should().Be(2);
            puzzle[5, 3].Should().Be(6);
            puzzle[5, 4].Should().Be(8);
            puzzle[5, 5].Should().Be(5);
            puzzle[5, 6].Should().Be(3);
            puzzle[5, 7].Should().Be(7);
            puzzle[5, 8].Should().Be(9);
            puzzle[5, 9].Should().Be(1);

            puzzle[6, 1].Should().Be(7);
            puzzle[6, 2].Should().Be(1);
            puzzle[6, 3].Should().Be(3);
            puzzle[6, 4].Should().Be(9);
            puzzle[6, 5].Should().Be(2);
            puzzle[6, 6].Should().Be(4);
            puzzle[6, 7].Should().Be(8);
            puzzle[6, 8].Should().Be(5);
            puzzle[6, 9].Should().Be(6);

            puzzle[7, 1].Should().Be(9);
            puzzle[7, 2].Should().Be(6);
            puzzle[7, 3].Should().Be(1);
            puzzle[7, 4].Should().Be(5);
            puzzle[7, 5].Should().Be(3);
            puzzle[7, 6].Should().Be(7);
            puzzle[7, 7].Should().Be(2);
            puzzle[7, 8].Should().Be(8);
            puzzle[7, 9].Should().Be(4);

            puzzle[8, 1].Should().Be(2);
            puzzle[8, 2].Should().Be(8);
            puzzle[8, 3].Should().Be(7);
            puzzle[8, 4].Should().Be(4);
            puzzle[8, 5].Should().Be(1);
            puzzle[8, 6].Should().Be(9);
            puzzle[8, 7].Should().Be(6);
            puzzle[8, 8].Should().Be(3);
            puzzle[8, 9].Should().Be(5);

            puzzle[9, 1].Should().Be(3);
            puzzle[9, 2].Should().Be(4);
            puzzle[9, 3].Should().Be(5);
            puzzle[9, 4].Should().Be(2);
            puzzle[9, 5].Should().Be(8);
            puzzle[9, 6].Should().Be(6);
            puzzle[9, 7].Should().Be(1);
            puzzle[9, 8].Should().Be(7);
            puzzle[9, 9].Should().Be(9);
        }

        [Fact]
        public void SolvesVeryEasyPuzzle()
        {
            var puzzle = SudokuPuzzle.Parse(@"
534 678 912
672 195 348
198 342 567

859 761 423
426 853 791
713 924 856

961 537 284
287 419 635
345 286 179
");

            var result = this.testee.Solve(puzzle);

            Assert.False(true, "Not yet implemented");
        }
    }
}
