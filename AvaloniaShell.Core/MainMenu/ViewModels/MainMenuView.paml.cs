using Avalonia.Controls;

namespace AvaloniaShell.Core.MainMenu.ViewModels
{
    public class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            Avalonia.Markup.Xaml.AvaloniaXamlLoader.Load(this);
        }
    }
}
