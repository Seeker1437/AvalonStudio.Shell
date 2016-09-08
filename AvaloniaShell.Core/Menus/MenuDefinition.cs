using System;
using Avalonia.Input;
using AvaloniaShell.Core.Commands;

namespace AvaloniaShell.Core.Menus
{
    public class MenuDefinition : MenuDefinitionBase
    {
        public MenuBarDefinition MenuBar { get; }

        public override int SortOrder { get; }

        public override string Text { get; }

        public override Uri IconSource => null;

        public override KeyGesture KeyGesture => null;

        public override CommandDefinitionBase CommandDefinition => null;

        public MenuDefinition(MenuBarDefinition menuBar, int sortOrder, string text)
        {
            MenuBar = menuBar;
            SortOrder = sortOrder;
            Text = text;
        }
    }
}