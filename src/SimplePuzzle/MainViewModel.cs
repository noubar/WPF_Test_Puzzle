using System.Collections.ObjectModel;
using System.Windows.Input;
using SimplePuzzle.Infrastructure;

namespace SimplePuzzle
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<DataGridItem> DataGridItems { get; }


        public MainViewModel(bool puzzle1,bool puzzle2,bool puzzle3)
        {
            DataGridItems = new ObservableCollection<DataGridItem>
            {
                new DataGridItem { PutMe = false,  Solution = puzzle1 },
                new DataGridItem { PutMe = false,  Solution = puzzle2 },
                new DataGridItem { PutMe = false,  Solution = puzzle3 },
            };

        }
    }
}
