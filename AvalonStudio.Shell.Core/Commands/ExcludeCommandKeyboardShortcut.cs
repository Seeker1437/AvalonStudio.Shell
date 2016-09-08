namespace AvalonStudio.Shell.Core.Commands
{
    public class ExcludeCommandKeyboardShortcut
    {
        public CommandKeyboardShortcut KeyboardShortcut { get; }

        public ExcludeCommandKeyboardShortcut(CommandKeyboardShortcut keyboardShortcut)
        {
            KeyboardShortcut = keyboardShortcut;
        }
    }
}