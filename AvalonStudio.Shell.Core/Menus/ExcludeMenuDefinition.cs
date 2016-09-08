namespace AvalonStudio.Shell.Core.Menus
{
    public class ExcludeMenuDefinition
    {
        public MenuDefinition MenuDefinitionToExclude { get; }

        public ExcludeMenuDefinition(MenuDefinition menuDefinition)
        {
            MenuDefinitionToExclude = menuDefinition;
        }
    }
}
