using AvaloniaShell.Core.Menus;

namespace AvaloniaShell.Core.MainMenu
{
    public static class MenuDefinitions
    {
        [MenuBar]
        public static MenuBarDefinition MainMenuBar => new MenuBarDefinition();

        [Menu]
        public static MenuDefinition FileMenu => new MenuDefinition(MainMenuBar, 0, "_File");
    }
}
