namespace AvaloniaShell.Core.ToolBars
{
	public class ExcludeToolBarItemGroupDefinition
	{
		public ToolBarItemGroupDefinition ToolBarItemGroupDefinitionToExclude { get; }

		public ExcludeToolBarItemGroupDefinition(ToolBarItemGroupDefinition toolBarItemGroupDefinition)
		{
			ToolBarItemGroupDefinitionToExclude = toolBarItemGroupDefinition;
		}
	}
}