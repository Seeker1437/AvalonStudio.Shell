using System;
using ReactiveUI;

namespace AvalonStudio.Shell.Core.Dialogs
{
	public class ModalDialogViewModelBase : ReactiveObject
	{
		public ModalDialogViewModelBase(string title, bool okButton = true, bool cancelButton = true)
		{
			OkButtonVisible = okButton;
			CancelButtonVisible = cancelButton;

			_isVisible = false;
			this._title = title;

			CancelCommand = ReactiveCommand.Create();
			CancelCommand.Subscribe(_ => { Close(); });
		}

		private bool _cancelButtonVisible = false;
		public bool CancelButtonVisible
		{
			get { return _cancelButtonVisible; }
			set { this.RaiseAndSetIfChanged(ref _cancelButtonVisible, value); }
		}

		private bool _okButtonVisible = false;
		public bool OkButtonVisible
		{
			get { return _okButtonVisible; }
			set { this.RaiseAndSetIfChanged(ref _okButtonVisible, value); }
		}

		public virtual ReactiveCommand<object> OkCommand { get; protected set; }
		public ReactiveCommand<object> CancelCommand { get; private set; }

		private string _title;
		public string Title
		{
			get { return _title; }
			private set { this.RaiseAndSetIfChanged(ref _title, value); }
		}

		private bool _isVisible;
		public bool IsVisible
		{
			get { return _isVisible; }
			set { this.RaiseAndSetIfChanged(ref _isVisible, value); }
		}

		public void ShowDialog()
		{
			this.IsVisible = true;
		}

		public void Close()
		{
			this.IsVisible = false;
		}
	}

	public abstract class ModalDialogReactiveObject<T> : ModalDialogViewModelBase
	{
		protected ModalDialogReactiveObject(T model, string title) : base(title)
		{
			this.Model = model;
		}

		public T Model { get; private set; }
	}
}
