using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Core
{
    internal sealed class PuzzleValidator
    {
        internal static ValidationResult Validate(SudokuPuzzle puzzle)
        {
            var result = ValidateEachNumberOnlyOnceInARow(puzzle);

            if (!result.Valid)
            {
                return result;
            }

            result = ValidateEachNumberOnlyOnceInAColumn(puzzle);

            if (!result.Valid)
            {
                return result;
            }

            return ValidateEachNumberOnlyOnceInASection(puzzle);
        }

        private static ValidationResult ValidateEachNumberOnlyOnceInARow(SudokuPuzzle puzzle)
        {
            for (int rowNr = 1; rowNr <= 9; rowNr++)
            {
                var numbersInRow = new List<byte>();

                for (int columnNr = 1; columnNr <= 9; columnNr++)
                {
                    var positionValue = puzzle[rowNr, columnNr];

                    if (!positionValue.HasValue)
                    {
                        return ValidationResult.CreateInvalid(
                            $"Value missing at position: row={rowNr}, column={columnNr}",
                            rowNr,
                            columnNr);
                    }

                    var number = positionValue.Value;
                    numbersInRow.Add(number);
                }

                var distinct = numbersInRow.Distinct().ToArray();
                if (!distinct.SequenceEqual(numbersInRow))
                {
                    var differentIndexes = distinct.Select((item, index) => new { item, index })
                        .Where(x => x.item != numbersInRow[x.index])
                        .Select(x => x.index)
                        .ToArray();
                    var differentColumnNr = differentIndexes.Any() ? differentIndexes.First() + 1 : 9;

                    return ValidationResult.CreateInvalid(
                        $"Row {rowNr} is invalid",
                        rowNr, differentColumnNr);
                }
            }

            return ValidationResult.CreateValid();
        }

        private static ValidationResult ValidateEachNumberOnlyOnceInAColumn(SudokuPuzzle puzzle)
        {
            for (int columnNr = 1; columnNr <= 9; columnNr++)
            {
                var numbersInColumn = new List<byte>();

                for (int rowNr = 1; rowNr <= 9; rowNr++)
                {
                    var positionValue = puzzle[rowNr, columnNr];

                    if (!positionValue.HasValue)
                    {
                        return ValidationResult.CreateInvalid(
                            $"Value missing at position: row={rowNr}, column={columnNr}", rowNr, columnNr);
                    }

                    var number = positionValue.Value;
                    numbersInColumn.Add(number);
                }

                var distinct = numbersInColumn.Distinct().ToArray();
                if (!distinct.SequenceEqual(numbersInColumn))
                {
                    var differentIndexes = distinct.Select((item, index) => new { item, index })
                        .Where(x => x.item != numbersInColumn[x.index])
                        .Select(x => x.index)
                        .ToArray();
                    var differentRowNr = differentIndexes.Any() ? differentIndexes.First() + 1 : 9;

                    return ValidationResult.CreateInvalid(
                        $"Column {columnNr} is invalid", differentRowNr, columnNr);
                }
            }

            return ValidationResult.CreateValid();
        }

        private static ValidationResult ValidateEachNumberOnlyOnceInASection(SudokuPuzzle puzzle)
        {
            for (int sectionIndex = 0; sectionIndex < 9; sectionIndex++)
            {
                var numbersInSection = new List<byte>();

                for (int number = 1; number <= 9; number++)
                {
                    int rowNr = number % 3 == 0 ? 3 : number % 3;
                    int columnNr = (int)Math.Ceiling(number / 3d);

                    int absoluteRowNr = rowNr + ((sectionIndex % 3) * 3);
                    int absoluteColumnNr = columnNr + ((sectionIndex % 3) * 3);

                    var positionValue = puzzle[absoluteRowNr, absoluteColumnNr];

                    if (!positionValue.HasValue)
                    {
                        return ValidationResult.CreateInvalid(
                            $"Value missing at position: row={absoluteRowNr}, column={absoluteColumnNr}",
                            absoluteRowNr,
                            absoluteColumnNr);
                    }

                    var numberValue = positionValue.Value;
                    numbersInSection.Add(numberValue);
                }

                var distinct = numbersInSection.Distinct().ToArray();
                if (!distinct.SequenceEqual(numbersInSection))
                {
                    var differentIndexes = distinct.Select((item, index) => new { item, index })
                        .Where(x => x.item != numbersInSection[x.index])
                        .Select(x => x.index)
                        .ToArray();

                    var number = differentIndexes.Any() ? differentIndexes.First() + 1 : 9;

                    int rowNr = number % 3 == 0 ? 3 : number % 3;
                    int columnNr = (int)Math.Ceiling(number / 3d);

                    int absoluteRowNr = rowNr + ((sectionIndex % 3) * 3);
                    int absoluteColumnNr = columnNr + ((sectionIndex % 3) * 3);

                    return ValidationResult.CreateInvalid(
                        $"Section {sectionIndex + 1} is invalid",
                        absoluteRowNr,
                        absoluteColumnNr);
                }
            }

            return ValidationResult.CreateValid();
        }
    }
}