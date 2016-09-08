using System;
using System.Composition;

namespace AvalonStudio.Shell.Core.Commands
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
