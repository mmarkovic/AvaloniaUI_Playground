namespace AvaloniaMvvmAppUI.Views
{
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}