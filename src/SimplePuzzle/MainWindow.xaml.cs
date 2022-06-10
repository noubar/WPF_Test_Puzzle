using System.Windows;
using System.Windows.Controls;
using System;

namespace SimplePuzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public bool puzzle1 { get; set; }
        public bool puzzle2 { get; set; }
        public bool puzzle3 { get; set; }
        public string flag1 { get; set; }
        public string flag2 { get; set; }
        public string flag3 { get; set; }
        public Guid userNameGuid { get; set; }
        public Guid passwordGuid { get; set; }
        public MainViewModel vm { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            var random = new Random();
            puzzle1 = random.Next(2) == 1 ? true : false;
            puzzle2 = random.Next(2) == 1 ? true : false;
            puzzle3 = random.Next(2) == 1 ? true : false;
            userNameGuid = Guid.NewGuid();
            passwordGuid = Guid.NewGuid();
            flag1 = Guid.NewGuid().ToString().Substring(0,8);
            flag2 = Guid.NewGuid().ToString().Substring(0,8);
            flag3 = Guid.NewGuid().ToString().Substring(0,8);
            vm = new MainViewModel(puzzle1, puzzle2, puzzle3);
            DataContext = vm;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in e.AddedItems)
            {
                var textBlock = (TextBlock) item;
                if (textBlock.Text == "Item 4")
                {
                    MessageBox.Show("Do you really want to do it?");
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userNameTextBox.Text = userNameGuid.ToString();
            passwordTextBox.Text = passwordGuid.ToString();
        }

        private void Stage1Botton_Click(object sender, RoutedEventArgs e)
        {
            if (userNameTextBox.Text == passwordGuid.ToString() && passwordTextBox.Text == userNameGuid.ToString())
            {
                MessageBox.Show(flag1);
            }
        }

        private void Stage2Botton_Click(object sender, RoutedEventArgs e)
        {
            bool a = vm.DataGridItems[0].PutMe;
            bool b = vm.DataGridItems[1].PutMe;
            bool c = vm.DataGridItems[2].PutMe;
            if (a == puzzle1 && b == puzzle2 && c == puzzle3)
            {
                MessageBox.Show(flag2);
            }
        }

        private void Stage3Botton_Click(object sender, RoutedEventArgs e)
        {
            if (flag1TextBox.Text == flag1 && flag2TextBox.Text == flag2)
            {
                MessageBox.Show("Congratulation");
            }
        }
    }
}
