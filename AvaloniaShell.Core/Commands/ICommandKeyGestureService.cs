using Avalonia.Controls;
using Avalonia.Input;

namespace AvaloniaShell.Core.Commands
{
    public interface ICommandKeyGestureService
    {
        void BindKeyGestures(Control uiElement);
        KeyGesture GetPrimaryKeyGesture(CommandDefinitionBase commandDefinition);
    }
}