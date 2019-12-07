namespace AvaloniaMvvmAppUI.ViewModels
{
    using Sudoku.Core;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            this.PuzzleViewModel = new PuzzleViewModel();
        }

        public string Greeting => "Hello World!";

        public PuzzleViewModel PuzzleViewModel { get; }

        public void LoadPuzzle()
        {
            this.PuzzleViewModel.Load(PuzzleProvider.SamplePuzzle1);
        }
        public void LoadSolution()
        {
            this.PuzzleViewModel.Load(PuzzleProvider.SamplePuzzle1Solution);
        }
    }
}
