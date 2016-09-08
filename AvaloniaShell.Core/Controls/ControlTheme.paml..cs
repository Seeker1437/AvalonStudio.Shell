using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace AvaloniaShell.Core.Controls
{
	public class ControlTheme : Styles
	{
		public ControlTheme()
		{
			AvaloniaXamlLoader.Load(this);
		}
	}
}