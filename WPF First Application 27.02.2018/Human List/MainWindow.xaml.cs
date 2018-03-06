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

namespace Human_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Human> Individuals = new List<Human>();
            Individuals.Add(new Human() { Name = "Edmund Falkreath", Age = 22, Gender = "Male" });
            Individuals.Add(new Human() { Name = "Sicilia Falkreath", Age = 19, Gender = "Female" });
            Individuals.Add(new Human() { Name = "Torygg Kr'adat", Age = 45, Gender = "Male" });
            Individuals.Add(new Human() { Name = "Tormunda Berethor", Age = 62, Gender = "Female" });
            Individuals.Add(new Human() { Name = "Ulfric Stormcloack", Age = 24, Gender = "Male" });
            Individuals.Add(new Human() { Name = "Argo Detyrre", Age = 28, Gender = "Male" });
            Individuals.Add(new Human() { Name = "Sara Maye", Age = 9, Gender = "Female" });
            Individuals.Add(new Human() { Name = "Myra Tottingham", Age = 35, Gender = "Male" });
            Individuals.Add(new Human() { Name = "Evelyn Carcrest", Age = 72, Gender = "Female" });
            Individuals.Add(new Human() { Name = "Mohammed Thovyn", Age = 89, Gender = "Male" });

            NameListBox.ItemsSource = Individuals;
        }

        //private void NameListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Title = (NameListBox.SelectedItem as Human).Title;
        //}

        //private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        //{
        //    if (NameListBox.SelectedItem != null)
        //        MessageBox.Show((NameListBox.SelectedItem as Human).Title);
        //}

        //private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        //{
        //    NameListBox.SelectedIndex = NameListBox.Items.Count - 1;
        //}

        //private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        //{
        //    int nextIndex = 0;
        //    if ((NameListBox.SelectedIndex >= 0) && (NameListBox.SelectedIndex < (NameListBox.Items.Count - 1)))
        //    {
        //        nextIndex = NameListBox.SelectedIndex + 1;
        //    }
        //    NameListBox.SelectedIndex = nextIndex;
        //}

        //private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in NameListBox.Items)
        //    {
        //        if ((item is Human) && ((item as Human).Title.Contains("C#")))
        //        {
        //            NameListBox.SelectedItem = item;
        //            break;
        //        }
        //    }
        //}

        public class Human
        {
            public string Title { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Gender { get; set; }
        }
    }
}
