using AvaloniaShell.Core.MVVM;

namespace AvaloniaShell.Core.ToolBars
{
	public interface IToolBars
	{
		IObservableCollection<IToolBar> Items {get;}
		bool Visible { get; set; }
	}
}