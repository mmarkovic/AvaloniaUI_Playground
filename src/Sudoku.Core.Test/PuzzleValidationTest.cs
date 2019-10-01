namespace Sudoku.Core.Test
{
    using FluentAssertions;
    using Xunit;

    public class PuzzleValidationTest
    {
        private readonly PuzzleSolver testee;

        public PuzzleValidationTest()
        {
            this.testee = new PuzzleSolver();
        }

        [Fact]
        public void ChecksSolvedPuzzle()
        {
            var puzzle = SudokuPuzzle.Parse(@"
534|678|912
672|195|348
198|342|567
-----------
859|761|423
426|853|791
713|924|856
-----------
961|537|284
287|419|635
345|286|179");

            var result = this.testee.Validate(puzzle);

            result.Valid.Should().BeTrue($"the puzzle is valid - {result.Message}");
        }

        [Fact]
        public void ChecksNumbersOfEachRow()
        {
            var invalidPuzzleAtRow5 = SudokuPuzzle.Parse(@"
534|678|912
672|195|348
198|342|567
-----------
859|761|423
426|853|891
713|924|856
-----------
961|537|284
287|419|635
345|286|179");

            var result = this.testee.Validate(invalidPuzzleAtRow5);

            result.Valid.Should().BeFalse($"the puzzle is invalid because of a double 8 in row 5");
        }

        [Fact]
        public void ChecksNumbersOfEachColumn()
        {
            var invalidPuzzleAtColumn4 = SudokuPuzzle.Parse(@"
514|678|932
672|195|348
398|142|567
-----------
859|764|123
426|853|791
743|921|856
-----------
961|537|284
287|139|615
135|286|479");

            var result = this.testee.Validate(invalidPuzzleAtColumn4);

            result.Valid.Should().BeFalse($"the puzzle is invalid because of a double 1 in column 4");
        }

        [Fact]
        public void ChecksNumbersOfEachSection()
        {
            var invalidPuzzleAtSection1 = SudokuPuzzle.Parse(@"
534|678|912
672|195|348
398|142|567
-----------
859|764|123
426|853|791
743|921|856
-----------
961|537|284
287|419|635
135|286|479");

            var result = this.testee.Validate(invalidPuzzleAtSection1);

            result.Valid.Should().BeFalse($"the puzzle is invalid because of a double 3 in section 1");
        }
    }
}