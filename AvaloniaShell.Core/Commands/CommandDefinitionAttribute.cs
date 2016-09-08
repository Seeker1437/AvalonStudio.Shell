using System;
using System.Composition;

namespace AvaloniaShell.Core.Commands
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandDefinitionAttribute : ExportAttribute
    {
        public CommandDefinitionAttribute()
            : base(typeof(CommandDefinitionBase))
        {

        }
    }
}
