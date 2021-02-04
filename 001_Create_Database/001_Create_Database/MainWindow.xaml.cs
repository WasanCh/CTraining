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

namespace _001_Create_Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddDatabase.InitializeDatabase();
            
            
            
            
        }

        private void ShowDataBase_Button_Click(object sender, RoutedEventArgs e)
        {

            string data = "";
            foreach(string inside in ShowDataOnTable.GetData())
            {
                data = data + " " + inside + "\n";
            }
            ShowData_TextBox.Text = data;


        }

        private void ShowData_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddDataTable.AddData(AddData_TextBox.Text);
            AddData_TextBox.Text = "";
        }
    }
}
