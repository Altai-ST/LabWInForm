using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace SortClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void ChangeColor(object sender, MouseEventArgs e)
        {
            start.Foreground = Brushes.Yellow;
        }

        private void ReturnColor(object sender, MouseEventArgs e)
        {
            start.Foreground = Brushes.Blue;
        }
    }
}
