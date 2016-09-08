using System.Windows.Input;

namespace AvaloniaShell.Core.Menus
{
    public interface IMenuItem
    {
        string Title { get; }
        ICommand Command { get; } 
    }
}
