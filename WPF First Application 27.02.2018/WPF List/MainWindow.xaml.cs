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

namespace WPF_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ToDoItem> Items = new List<ToDoItem>();
            Items.Add(new ToDoItem() { Title = "Complete this WPF Tutorial.", Completion = 45 });
            Items.Add(new ToDoItem() { Title = "Learn C#.", Completion = 80 });
            Items.Add(new ToDoItem() { Title = "Go to Shop.", Completion = 100 });
            Items.Add(new ToDoItem() { Title = "Buy stuff.", Completion = 10 });

            //ToDoListbox.ItemsSource = Items;

        }
    }

    public class ToDoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
