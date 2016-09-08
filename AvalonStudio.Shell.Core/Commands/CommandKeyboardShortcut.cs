using System;
using Avalonia.Input;

namespace AvalonStudio.Shell.Core.Commands
{
    //using Caliburn.Micro;

    public abstract class CommandKeyboardShortcut
    {
        private readonly Func<CommandDefinitionBase> _commandDefinition;

        public CommandDefinitionBase CommandDefinition => _commandDefinition();

        public KeyGesture KeyGesture { get; }

        public int SortOrder { get; }

        protected CommandKeyboardShortcut(KeyGesture keyGesture, int sortOrder, Func<CommandDefinitionBase> commandDefinition)
        {
            _commandDefinition = commandDefinition;
            KeyGesture = keyGesture;
            SortOrder = sortOrder;
        }
    }

    public class CommandKeyboardShortcut<TCommandDefinition> : CommandKeyboardShortcut
        where TCommandDefinition : CommandDefinition
    {
        public CommandKeyboardShortcut(KeyGesture keyGesture, int sortOrder = 5)
            : base(keyGesture, sortOrder, () => IoC.Get<ICommandService>().GetCommandDefinition(typeof(TCommandDefinition)))
        {
        }
    }
}