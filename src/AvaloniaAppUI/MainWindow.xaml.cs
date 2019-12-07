using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaAppUI
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Icon = new WindowIcon("puzzle.ico");
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}