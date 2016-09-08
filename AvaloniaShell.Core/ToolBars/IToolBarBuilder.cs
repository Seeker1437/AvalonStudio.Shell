namespace AvaloniaShell.Core.ToolBars
{
	public interface IToolBarBuilder
	{
		void BuildToolBars(IToolBars result);
		void BuildToolBar(ToolBarDefinition toolBarDefinition, IToolBar result);
	}
}