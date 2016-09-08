using AvaloniaShell.Core.Dialogs;

namespace AvaloniaShell.Core.Shell
{
	public interface IShell
	{
		ModalDialogViewModelBase ModalDialog { get; set; }
	}
}
