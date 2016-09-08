using AvalonStudio.Shell.Core.MainMenu.Models;
using AvalonStudio.Shell.Core.Menus;

namespace AvalonStudio.Shell.Core.MainMenu
{
    public interface IMenuBuilder
    {
        void BuildMenuBar(MenuBarDefinition menuBarDefinition, MenuModel result);
    }
}