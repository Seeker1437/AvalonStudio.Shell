using AvalonStudio.Shell.Core.Dialogs;

namespace AvalonStudio.Shell.Core.Shell
{
	public interface IShell
	{
		ModalDialogViewModelBase ModalDialog { get; set; }
	}
}
