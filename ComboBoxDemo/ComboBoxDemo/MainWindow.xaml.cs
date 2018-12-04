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

namespace ComboBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comboBoxColors.ItemsSource = typeof(Colors).GetProperties();

            
        }

        private void comboBoxColors_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void changeColor(object sender, SelectionChangedEventArgs e)
        {
            //Colors selectedColor = (Colors)(comboBoxColors.SelectedItem);
            this.Background = new SolidColorBrush(Colors.Beige);
        }
    }
}
