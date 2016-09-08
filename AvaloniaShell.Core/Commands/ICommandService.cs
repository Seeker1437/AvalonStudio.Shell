using System;

namespace AvaloniaShell.Core.Commands
{
    public interface ICommandService
    {
        CommandDefinitionBase GetCommandDefinition(Type commandDefinitionType);
        Command GetCommand(CommandDefinitionBase commandDefinition);
    }
}