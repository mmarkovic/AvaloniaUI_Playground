namespace WpfCoreUI
{
    using System.Windows.Input;
    using Sudoku.Core;
    using WpfCoreUI.Puzzle;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.PuzzleViewModel = new PuzzleViewModel();
            this.LoadPuzzleCommand = new RelayCommand(this.LoadPuzzle, _ => true);
            this.CheckInputCommand = new RelayCommand(this.CheckInput, _ => true);
            this.LoadSolutionCommand = new RelayCommand(this.LoadSolution, _ => true);
        }

        public PuzzleViewModel PuzzleViewModel { get; set; }

        public ICommand LoadPuzzleCommand { get; }

        public ICommand CheckInputCommand { get; }

        public ICommand LoadSolutionCommand { get; }

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
