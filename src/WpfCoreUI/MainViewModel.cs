using WpfCoreUI.Puzzle;

namespace WpfCoreUI
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Puzzle = new PuzzleViewModel();
            this.Puzzle.Box1Square1 = 1;
            this.Puzzle.Box1Square2 = 2;
            this.Puzzle.Box1Square3 = 3;
        }

        public PuzzleViewModel Puzzle { get; set; }
    }
}
