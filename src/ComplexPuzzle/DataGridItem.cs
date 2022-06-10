using ComplexPuzzle.Infrastructure;

namespace ComplexPuzzle
{
    public class DataGridItem : ObservableObject
    {
        public DataGridItem()
        {
            this.t1 = false;
            this.t2 = false;
            this.t3 = false;
            this.t4 = false;
            this.t5 = false;
            this.t6 = false;
            this.t7 = false;
            this.t8 = false;
            //this.t9 = false;
            //this.t10 = false;
            //this.t11 = false;
            //this.t12 = false;
            //this.t13 = false;
            //this.t14 = false;
            //this.t15 = false;
            //this.t16 = false;
        }

        public bool t1
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t2
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t3
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t4
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t5        
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t6
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t7
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }
        public bool t8
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }       
        //public bool t9
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}

        //public bool t10
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}

        //public bool t11
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}

        //public bool t12
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}
        //public bool t13   
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}
        //public bool t14
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}
        //public bool t15
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}
        //public bool t16
        //{
        //    get => GetProperty<bool>();
        //    set => SetProperty(value);
        //}
    }
}
