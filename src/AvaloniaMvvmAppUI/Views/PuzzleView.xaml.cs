namespace AvaloniaMvvmAppUI.Views
{
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    
    public class PuzzleView : UserControl
    {
        public PuzzleView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
