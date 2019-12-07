using Avalonia;
using Avalonia.Markup.Xaml;

namespace AvaloniaMvvmAppUI
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}