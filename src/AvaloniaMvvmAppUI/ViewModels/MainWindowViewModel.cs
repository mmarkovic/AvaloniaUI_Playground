namespace AvaloniaMvvmAppUI.ViewModels
{
    using Sudoku.Core;

    public class MainWindowViewModel : ViewModelBase
    {
        public PuzzleViewModel PuzzleViewModel { get; } = new PuzzleViewModel();

        public void LoadPuzzle()
        {
            this.PuzzleViewModel.Load(PuzzleProvider.SamplePuzzle1);
        }

        public void CheckInput()
        {
            this.PuzzleViewModel.CheckInput(PuzzleProvider.SamplePuzzle1Solution);
        }

        public void LoadSolution()
        {
            this.PuzzleViewModel.Load(PuzzleProvider.SamplePuzzle1Solution);
        }
    }
}
