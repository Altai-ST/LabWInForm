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

namespace MenuSort
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listSort.ItemsSource = new SortList[]
        {
            new SortList { Name = "Блинная сортировка" },
            new SortList { Name = "Рандомная сортировка" },
            new SortList { Name = "Циклическая сортировка" }
        };
            listSort.SelectedIndex = 0;
        }

        private void SelectSort(object sender, SelectionChangedEventArgs e)
        {
            if(listSort.SelectedItem is { })
            {
                nameSort.Text = listSort.SelectedValue.ToString();
            }
        }
    }
    public class SortList
    {
        public string Name { get; set; } = "";
        public override string ToString() => $"{Name}";
    }
}
