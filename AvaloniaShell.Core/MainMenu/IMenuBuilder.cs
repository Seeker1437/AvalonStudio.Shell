using AvaloniaShell.Core.MainMenu.Models;
using AvaloniaShell.Core.Menus;

namespace AvaloniaShell.Core.MainMenu
{
    public interface IMenuBuilder
    {
        void BuildMenuBar(MenuBarDefinition menuBarDefinition, MenuModel result);
    }
}