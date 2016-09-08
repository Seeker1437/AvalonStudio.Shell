using AvalonStudio.Shell.Core.MVVM;

namespace AvalonStudio.Shell.Core.ToolBars
{
	public interface IToolBars
	{
		IObservableCollection<IToolBar> Items {get;}
		bool Visible { get; set; }
	}
}