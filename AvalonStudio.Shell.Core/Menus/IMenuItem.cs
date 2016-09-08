using System.Windows.Input;

namespace AvalonStudio.Shell.Core.Menus
{
    public interface IMenuItem
    {
        string Title { get; }
        ICommand Command { get; } 
    }
}
