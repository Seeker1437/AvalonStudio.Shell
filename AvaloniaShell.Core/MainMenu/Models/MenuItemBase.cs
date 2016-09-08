using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaShell.Core.Util;
using ReactiveUI;

namespace AvaloniaShell.Core.MainMenu.Models
{
	public class MenuItemBase : ReactiveObject, IEnumerable<MenuItemBase>
	{
		#region Static stuff

		public static MenuItemBase Separator
		{
			get { return new MenuItemSeparator(); }
		}

		#endregion

		#region Properties

		public ObservableCollection<MenuItemBase> Children { get; private set; }

		#endregion

		#region Constructors

		protected MenuItemBase()
		{
			Children = new ObservableCollection<MenuItemBase>();
		}

		#endregion

		public void Add(params MenuItemBase[] menuItems)
		{
			menuItems.Apply(Children.Add);
		}

		public IEnumerator<MenuItemBase> GetEnumerator()
		{
			return Children.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}