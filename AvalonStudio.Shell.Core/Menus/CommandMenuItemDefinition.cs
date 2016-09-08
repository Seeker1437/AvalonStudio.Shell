using System;
using Avalonia.Input;
using AvalonStudio.Shell.Core.Commands;

namespace AvalonStudio.Shell.Core.Menus
{
    public class CommandMenuItemDefinition<TCommandDefinition> : MenuItemDefinition
        where TCommandDefinition : CommandDefinitionBase
    {
        private readonly CommandDefinitionBase _commandDefinition;

        public override string Text => _commandDefinition.Text;

        public override Uri IconSource => _commandDefinition.IconSource;

        public override KeyGesture KeyGesture { get; }

        public override CommandDefinitionBase CommandDefinition => _commandDefinition;

        public CommandMenuItemDefinition(MenuItemGroupDefinition group, int sortOrder)
            : base(group, sortOrder)
        {
            var commandService = IoC.Get<ICommandService>();
            _commandDefinition = commandService.GetCommandDefinition(typeof(TCommandDefinition));
            KeyGesture = IoC.Get<ICommandKeyGestureService>().GetPrimaryKeyGesture(_commandDefinition);
        }
    }
}