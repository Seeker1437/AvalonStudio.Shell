using Avalonia.Controls;
using Avalonia.Input;

namespace AvalonStudio.Shell.Core.Commands
{
    public interface ICommandKeyGestureService
    {
        void BindKeyGestures(Control uiElement);
        KeyGesture GetPrimaryKeyGesture(CommandDefinitionBase commandDefinition);
    }
}