using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace AvalonStudio.Shell.Core.Controls
{
	public class ControlTheme : Styles
	{
		public ControlTheme()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}