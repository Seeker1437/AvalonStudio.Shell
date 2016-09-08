using System;

namespace AvalonStudio.Shell.Core.Commands
{
    public interface ICommandService
    {
        CommandDefinitionBase GetCommandDefinition(Type commandDefinitionType);
        Command GetCommand(CommandDefinitionBase commandDefinition);
    }
}