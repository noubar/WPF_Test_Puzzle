using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ComplexPuzzle.Infrastructure;

namespace ComplexPuzzle
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<DataGridItem> DataGridItems { get; }


        public MainViewModel(bool[,] cells)
        {

            // fill it
            DataGridItems = new ObservableCollection<DataGridItem>
            {
            };

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                DataGridItems.Add(new DataGridItem());
                DataGridItems[i].t1 = cells[i, 0];
                DataGridItems[i].t2 = cells[i, 1];
                DataGridItems[i].t3 = cells[i, 2];
                DataGridItems[i].t4 = cells[i, 3];
                DataGridItems[i].t5 = cells[i, 4];
                DataGridItems[i].t6 = cells[i, 5];
                DataGridItems[i].t7 = cells[i, 6];
                DataGridItems[i].t8 = cells[i, 7];
            }
        }
    }
}
