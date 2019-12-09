namespace WpfCoreUI.Puzzle
{
    using System.ComponentModel;

    public class SquareViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsPredefinedValue { get; set; }
        
        public bool? IsValueCorrect { get; set; }

        public byte? Value { get; set; }
    }
}