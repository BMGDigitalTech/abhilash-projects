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

namespace ListBoxListCurrentMatches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Match> matches = new List<Match>
            {
                new Match { Team1="Bayern Munich", Team2="Real Madrid", Score1=3, Score2=2, Completion=85},
                new Match { Team1="PSG", Team2="Barca", Score1=3, Score2=2, Completion=55},
                new Match { Team1="BVB Dortmund", Team2="AS Roma", Score1=0, Score2=1, Completion=25},
                new Match { Team1="Man United", Team2="LA Galaxy", Score1=1, Score2=1, Completion=35},
            };

            LblMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(LblMatches.SelectedItem != null)
            {
                MessageBox.Show("Selected Match: "
                    + (LblMatches.SelectedItem as Match).Team1 + " " +
                      (LblMatches.SelectedItem as Match).Score1 + " " +
                      (LblMatches.SelectedItem as Match).Score2 + " " +
                      (LblMatches.SelectedItem as Match).Team2
                    );
            }
        }
    }

    public class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }

    }
}
