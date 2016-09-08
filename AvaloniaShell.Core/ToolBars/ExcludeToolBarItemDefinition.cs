namespace AvaloniaShell.Core.ToolBars
{
	public class ExcludeToolBarItemDefinition
	{
		public ToolBarItemDefinition ToolBarItemDefinitionToExclude { get; }

		public ExcludeToolBarItemDefinition(ToolBarItemDefinition toolBarItemDefinition)
		{
			ToolBarItemDefinitionToExclude = toolBarItemDefinition;
		}
	}
}