namespace AvaloniaMvvmAppUI.Views
{
    using System;
    using System.ComponentModel;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    using AvaloniaMvvmAppUI.ViewModels;

    public class BoxView : UserControl
    {
        public BoxView()
        {
            this.InitializeComponent();
            this.DataContextChanged += this.OnDataContextChanged;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnDataContextChanged(object _, EventArgs __)
        {
            var boxViewModel = this.DataContext as BoxViewModel;
            if (boxViewModel == null)
            {
                return;
            }

            boxViewModel.Square1.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 1);
            boxViewModel.Square2.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 2);
            boxViewModel.Square3.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 3);
            boxViewModel.Square4.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 4);
            boxViewModel.Square5.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 5);
            boxViewModel.Square6.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 6);
            boxViewModel.Square7.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 7);
            boxViewModel.Square8.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 8);
            boxViewModel.Square9.PropertyChanged += (s, e) => this.BoxViewModelOnPropertyChanged(s, e, 9);
        }

        private void BoxViewModelOnPropertyChanged(
            object sender,
            PropertyChangedEventArgs e,
            int squareNumber)
        {
            if (e.PropertyName == nameof(SquareViewModel.IsPredefinedValue))
            {
                var squareViewModel = (SquareViewModel)sender;
                TextBox textBox = this.FindControl<TextBox>($"Square{squareNumber}");
                textBox.Classes.Clear();

                if (squareViewModel.IsPredefinedValue)
                {
                    textBox.Classes.Add("predefined");
                }
            }
        }
    }
}
