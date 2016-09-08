using System;
using Avalonia.Controls;

namespace AvalonStudio.Shell.Core.Extensions
{
	public interface IExtension
	{
		/// <summary>
		/// The header name of the Extension
		/// </summary>
		string Name { get; }

		/// <summary>
		/// The description for the Extension
		/// </summary>
		string Description { get; }

		/// <summary>
		/// Called while ControlPanel is initintializing, before tab is added and ran
		/// </summary>
		void Initialize();

		/// <summary>
		/// Called during discovery of Extension
		/// </summary>
		void Load();

		/// <summary>
		/// Runs the Extensions
		/// </summary>
		void Run();

		/// <summary>
		/// UIElement provided by this control
		/// </summary>
		/// <returns></returns>
		Control GetExtensionUi();

		/// <summary>
		/// Guid used to identify this application
		/// </summary>
		/// <returns></returns>
		Guid GetGuid();

		/// <summary>
		/// Called when the ControlPanel is closing.
		/// </summary>
		void Shutdown();
	}
}
