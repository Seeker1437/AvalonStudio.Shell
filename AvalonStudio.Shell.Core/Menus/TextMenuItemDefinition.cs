using System;
using Avalonia.Input;
using AvalonStudio.Shell.Core.Commands;

namespace AvalonStudio.Shell.Core.Menus
{
    public class TextMenuItemDefinition : MenuItemDefinition
    {
        public override string Text { get; }

        public override Uri IconSource { get; }

        public override KeyGesture KeyGesture => null;

        public override CommandDefinitionBase CommandDefinition => null;

        public TextMenuItemDefinition(MenuItemGroupDefinition group, int sortOrder, string text, Uri iconSource = null)
            : base(group, sortOrder)
        {
            Text = text;
            IconSource = iconSource;
        }
    }
}