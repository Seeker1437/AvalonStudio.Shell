using System.Composition;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Input;

namespace AvalonStudio.Shell.Core.Commands
{
    [Export(typeof(ICommandKeyGestureService))]
    public class CommandKeyGestureService : ICommandKeyGestureService
    {
        private readonly CommandKeyboardShortcut[] _keyboardShortcuts;
        private readonly ICommandService _commandService;

        [ImportingConstructor]
        public CommandKeyGestureService(
            [ImportMany] CommandKeyboardShortcut[] keyboardShortcuts,
            [ImportMany] ExcludeCommandKeyboardShortcut[] excludeKeyboardShortcuts,
            ICommandService commandService)
        {
            _keyboardShortcuts = keyboardShortcuts
                .Except(excludeKeyboardShortcuts.Select(x => x.KeyboardShortcut))
                .OrderBy(x => x.SortOrder)
                .ToArray();
            _commandService = commandService;
        }

        public void BindKeyGestures(Control uiElement)
        {
            foreach (var keyboardShortcut in _keyboardShortcuts.Where(keyboardShortcut => keyboardShortcut.KeyGesture != null))
            {
                (uiElement as Window)?.KeyBindings.Add(new KeyBinding() { Gesture = keyboardShortcut.KeyGesture, Command = keyboardShortcut.CommandDefinition.Command });
            }
        }

        public KeyGesture GetPrimaryKeyGesture(CommandDefinitionBase commandDefinition)
        {
            var keyboardShortcut = _keyboardShortcuts.FirstOrDefault(x => x.CommandDefinition == commandDefinition);
            return keyboardShortcut?.KeyGesture;
        }
    }
}