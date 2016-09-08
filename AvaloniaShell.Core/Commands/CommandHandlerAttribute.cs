using System;
using System.Composition;

namespace AvaloniaShell.Core.Commands
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandHandlerAttribute : ExportAttribute
    {
        public CommandHandlerAttribute()
            : base(typeof(ICommandHandler))
        {
            
        }
    }
}