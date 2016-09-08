namespace AvalonStudio.Shell.Core.Menus
{
    public class ExcludeMenuItemGroupDefinition
    {
        public MenuItemGroupDefinition MenuItemGroupDefinitionToExclude { get; }

        public ExcludeMenuItemGroupDefinition(MenuItemGroupDefinition menuItemGroupDefinition)
        {
            MenuItemGroupDefinitionToExclude = menuItemGroupDefinition;
        }
    }
}
