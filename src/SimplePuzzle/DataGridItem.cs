using SimplePuzzle.Infrastructure;

namespace SimplePuzzle
{
    public class DataGridItem : ObservableObject
    {
        public bool PutMe
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }

        public bool Solution
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
    }
}
