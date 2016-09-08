using System;
using Avalonia.Controls.Shapes;

namespace AvalonStudio.Shell.Core.Commands
{
    public abstract class CommandDefinition : CommandDefinitionBase
    {
        public override Uri IconSource => null;

        public override Path IconPath => null;

        public sealed override bool IsList => false;
    }
}
