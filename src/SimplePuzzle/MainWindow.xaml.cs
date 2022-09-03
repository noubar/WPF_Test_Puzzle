using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimplePuzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Guid userNameGuid { get; set; }
        private Guid passwordGuid { get; set; }
        private string flag1 { get; set; }
        private string flag2 { get; set; }
        private bool[] Sol { get; set; } = new bool[3];
        private bool[] Put { get; set; } = new bool[3];


        public MainWindow()
        {
            InitializeComponent();
            generateSolutions();
            generateGuids();
            generateFlags();
        }

        private void generateSolutions()
        {
            var random = new Random();
            
            for (int i = 0; i < 3; i++)
            {
                checkedBoxRow ite = new checkedBoxRow();
                Sol[i] = random.Next(2) == 1 ? true : false;
                ite.PutMe = false;
                ite.Solution = Sol[i];
                Stage2DataGrid.Items.Add(ite);
            }
        }
        private void generateGuids()
        {
            userNameGuid = Guid.NewGuid();
            passwordGuid = Guid.NewGuid();
        }     
        private void generateFlags()
        {
            flag1 = Guid.NewGuid().ToString().Substring(0, 4);
            flag2 = Guid.NewGuid().ToString().Substring(0, 4);
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
            bool pass = true;
            for (int i = 0; i < 3; i++)
            {
                checkedBoxRow ite = new checkedBoxRow();
                ite = (checkedBoxRow)Stage2DataGrid.Items.GetItemAt(i);
                Put[i] = ite.PutMe;
            }            
            
            for (int i = 0; i < 3; i++)
            {
                if (Put[i] != Sol[i])
                {
                    pass = false;
                }
            }

            if (pass)
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
