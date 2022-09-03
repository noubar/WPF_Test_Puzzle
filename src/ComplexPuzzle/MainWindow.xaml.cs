using SimplePuzzle;
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

namespace ComplexPuzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool[,] cells { get; set; } = new bool[8,8];

        public bool row4match { get; set; }
        public bool column4match { get; set; }
        public bool positive4match { get; set; }
        public bool negative4match { get; set; }

        private bool usernameValid { get; set; }
        private bool passwordValid { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            generatePuzzle();
            generatetLogins();
        }
        enum loginRadioButton
        {
            UsernameInvalid,
            LoginInvalid,
            LoginValid

        };
        public void generatetLogins()
        {
            var random = new Random();
            usernameValid = random.Next(2) == 1 ? true : false;
            passwordValid = random.Next(2) == 1 ? true : false;
            if (usernameValid)
                usernameTextBox.Text = "Valid";
            else
                usernameTextBox.Text = "Invalid";
            if (passwordValid)
                passwordTextBox.Text = "Valid";
            else
                passwordTextBox.Text = "Invalid";
        }
        private void generatePuzzle()
        {
            shufle();
            for (int i = 0; i < 8; i++)
            {
                checkedBoxRow ite = new checkedBoxRow();
                ite.b0 = cells[i, 0];
                ite.b1 = cells[i, 1];
                ite.b2 = cells[i, 2];
                ite.b3 = cells[i, 3];
                ite.b4 = cells[i, 4];
                ite.b5 = cells[i, 5];
                ite.b6 = cells[i, 6];
                ite.b7 = cells[i, 7];
                PuzzleDataGrid.Items.Add(ite);
            }
            count();
        }


        public void shufle()
        {
            var random = new Random();
            bool[,] table = new bool[8, 8];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                { table[i, j] = random.Next(2) == 1 ? true : false; }
            }
            cells = table;
        }
        public void count()
        {
            row4match = row_match();
            column4match = column_match();
            positive4match = positive_match();
            negative4match = negative_match();
        }

        public bool row_match()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 3; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j - 3] == true && cells[i, j - 2] == true && cells[i, j - 1] == true && cells[i, j] == true)
                        return true;
                }
            }
            return false;
        }
        public bool column_match()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 3; j < cells.GetLength(1); j++)
                {
                    if (cells[j - 3, i] == true && cells[j - 2, i] == true && cells[j - 1, i] == true && cells[j, i] == true)
                        return true;
                }
            }
            return false;
        }
        public bool positive_match()
        {
            for (int i = 0; i < cells.GetLength(0) - 3; i++)
            {
                for (int j = 3; j < cells.GetLength(1); j++)
                {
                    if (cells[i + 3, j - 3] == true && cells[i + 2, j - 2] == true && cells[i + 1, j - 1] == true && cells[i, j] == true)
                        return true;
                }
            }
            return false;
        }

        public bool negative_match()
        {
            for (int i = 3; i < cells.GetLength(0); i++)
            {
                for (int j = 3; j < cells.GetLength(1); j++)
                {
                    if (cells[j - 3, i - 3] == true && cells[j - 2, i - 2] == true && cells[j - 1, i - 1] == true && cells[j, i] == true)
                        return true;
                }
            }
            return false;
        }

        private void complexBotton_Click(object sender, RoutedEventArgs e)
        {

            if (tableValid.IsChecked != null && tableInvalid.IsChecked != null && loginValid.IsChecked != null && loginInvalid.IsChecked != null)
            {
                bool tableValidInPlay = false;
                bool tableValidNeeded = false;

                loginRadioButton? loginRadioButtonInPlay = null;
                loginRadioButton loginRadioButtonNeeded;

                // decide if table should be valid
                if ((row4match && column4match) || (positive4match && negative4match))
                {
                    tableValidNeeded = true;
                }
                // decide which login state should be
                if (usernameValid == true && passwordValid == true)
                {
                    loginRadioButtonNeeded = loginRadioButton.LoginValid;
                }
                else if (usernameValid == false)
                {
                    loginRadioButtonNeeded = loginRadioButton.UsernameInvalid;
                }
                else // passwordValid = false
                {
                    loginRadioButtonNeeded = loginRadioButton.LoginInvalid;
                }

                if (tableValid.IsChecked.Value)
                {
                    tableValidInPlay = true;
                }
                if (usernameInvalid.IsChecked.Value)
                {
                    loginRadioButtonInPlay = loginRadioButton.UsernameInvalid;
                }
                if (loginInvalid.IsChecked.Value)
                {
                    loginRadioButtonInPlay = loginRadioButton.LoginInvalid;
                }
                if (loginValid.IsChecked.Value)
                {
                    loginRadioButtonInPlay = loginRadioButton.LoginValid;
                }

                if (tableValidInPlay == tableValidNeeded && loginRadioButtonInPlay == loginRadioButtonNeeded)
                {
                    MessageBox.Show("Congratulation");
                }
            }
        }
    }
}
