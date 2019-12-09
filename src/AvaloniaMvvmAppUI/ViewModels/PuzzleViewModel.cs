namespace AvaloniaMvvmAppUI.ViewModels
{
    using Sudoku.Core;

    public class PuzzleViewModel : ViewModelBase
    {
        public BoxViewModel Box1ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box2ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box3ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box4ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box5ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box6ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box7ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box8ViewModel { get; } = new BoxViewModel();

        public BoxViewModel Box9ViewModel { get; } = new BoxViewModel();

        public void Load(SudokuPuzzle puzzle)
        {
            this.SetBox(this.Box1ViewModel, puzzle, 0, 0);
            this.SetBox(this.Box2ViewModel, puzzle, 3, 0);
            this.SetBox(this.Box3ViewModel, puzzle, 6, 0);
            this.SetBox(this.Box4ViewModel, puzzle, 0, 3);
            this.SetBox(this.Box5ViewModel, puzzle, 3, 3);
            this.SetBox(this.Box6ViewModel, puzzle, 6, 3);
            this.SetBox(this.Box7ViewModel, puzzle, 0, 6);
            this.SetBox(this.Box8ViewModel, puzzle, 3, 6);
            this.SetBox(this.Box9ViewModel, puzzle, 6, 6);
        }

        public void SetBox(
            BoxViewModel boxViewModel,
            SudokuPuzzle puzzle,
            int columnOffset,
            int rowOffset)
        {
            boxViewModel.SetPredefined(1, puzzle[1 + rowOffset, 1 + columnOffset]);
            boxViewModel.SetPredefined(2, puzzle[1 + rowOffset, 2 + columnOffset]);
            boxViewModel.SetPredefined(3, puzzle[1 + rowOffset, 3 + columnOffset]);
            boxViewModel.SetPredefined(4, puzzle[2 + rowOffset, 1 + columnOffset]);
            boxViewModel.SetPredefined(5, puzzle[2 + rowOffset, 2 + columnOffset]);
            boxViewModel.SetPredefined(6, puzzle[2 + rowOffset, 3 + columnOffset]);
            boxViewModel.SetPredefined(7, puzzle[3 + rowOffset, 1 + columnOffset]);
            boxViewModel.SetPredefined(8, puzzle[3 + rowOffset, 2 + columnOffset]);
            boxViewModel.SetPredefined(9, puzzle[3 + rowOffset, 3 + columnOffset]);
        }
    }
}
