namespace Sudoku.Core
{
    using System.Collections.Generic;
    using System.Linq;

    public sealed class ValidationResult
    {
        public bool Valid { get; }

        public string Message { get; }

        public IReadOnlyCollection<InvalidPosition> InvalidPositions { get; }

        public ValidationResult(bool valid, string message, IEnumerable<InvalidPosition> invalidPositions)
        {
            this.Valid = valid;
            this.Message = message;
            this.InvalidPositions = invalidPositions.ToArray();
        }

        public static ValidationResult CreateInvalid(string message, int rowNumber, int columnNumber)
        {
            return new ValidationResult(
                false,
                message,
                new[] { new InvalidPosition(rowNumber, columnNumber) });
        }

        public static ValidationResult CreateValid()
        {
            return new ValidationResult(
                true, 
                string.Empty, 
                new InvalidPosition[0]);
        }
    }
}