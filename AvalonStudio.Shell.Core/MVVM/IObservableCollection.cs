using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace AvalonStudio.Shell.Core.MVVM
{
    public interface IObservableCollection<T> : IList<T>, INotifyPropertyChanged, INotifyCollectionChanged
    {

    }
}
