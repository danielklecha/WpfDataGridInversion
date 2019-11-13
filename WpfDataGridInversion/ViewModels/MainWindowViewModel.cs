using System.Collections.ObjectModel;
using System.Linq;
using WpfDataGridInversion.Models;

namespace WpfDataGridInversion.ViewModels
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        public MainWindowViewModel()
        {
            Records = new ObservableCollection<MyRecord>(Enumerable.Repeat(new MyRecord(), 1));
        }
        public ObservableCollection<MyRecord> Records { get; set; }
    }
}
