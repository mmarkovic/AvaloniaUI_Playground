using System.Windows.Input;
using Sudoku.Core;
using WpfCoreUI.Puzzle;

namespace WpfCoreUI
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Puzzle = new PuzzleViewModel();
            this.LoadPuzzleCommand = new RelayCommand(this.LoadPuzzle, _ => true);
        }

        public PuzzleViewModel Puzzle { get; set; }

        public ICommand LoadPuzzleCommand { get; }

        public void LoadPuzzle()
        {
            this.Puzzle.Load(PuzzleProvider.SamplePuzzle1);
        }
    }
}
