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

namespace WPF_First_Application_27._02._2018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string PrimeOperation = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(PrimeOperation == "Add")
            {
                Vastus.Content = int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text);
            }
            if(PrimeOperation == "Subtract")
            {
                Vastus.Content = int.Parse(TextBox1.Text) - int.Parse(TextBox2.Text);
            }
            if (PrimeOperation == "Multiply")
            {
                Vastus.Content = int.Parse(TextBox1.Text) * int.Parse(TextBox2.Text);
            }
            if (PrimeOperation == "Divide")
            {
                Vastus.Content = int.Parse(TextBox1.Text) / int.Parse(TextBox2.Text);
            }

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            _1.IsChecked = true;
            _2.IsChecked = false;
            _3.IsChecked = false;
            _4.IsChecked = false;

            PrimeOperation = "Add";
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            _1.IsChecked = false;
            _2.IsChecked = true;
            _3.IsChecked = false;
            _4.IsChecked = false;

            PrimeOperation = "Subtract";
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            _1.IsChecked = false;
            _2.IsChecked = false;
            _3.IsChecked = true;
            _4.IsChecked = false;

            PrimeOperation = "Multiply";
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            _1.IsChecked = false;
            _2.IsChecked = false;
            _3.IsChecked = false;
            _4.IsChecked = true;

            PrimeOperation = "Divide";
        }
    }
}
