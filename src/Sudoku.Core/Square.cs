namespace Sudoku.Core
{
    public abstract class Square
    {
        public abstract byte? Value { get; }

        public override string ToString()
        {
            return this.Value.HasValue ? this.Value.Value.ToString() : string.Empty;
        }
    }
}