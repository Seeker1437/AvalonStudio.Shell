namespace AvaloniaShell.Core.Commands
{
    public interface ICommandUiItem
    {
        CommandDefinitionBase CommandDefinition { get; }
        void Update(CommandHandlerWrapper commandHandler);
    }
}