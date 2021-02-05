//author: Mehul Thanki

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

namespace JokeAndPunchLineG4
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

        private void Setup_Click(object sender, RoutedEventArgs e)
        {
            LabelText.Text= "How many wizards does it take to change a lightbulb ?";
        }

        private void PunchLine_Click(object sender, RoutedEventArgs e)
        {
            LabelText.Text = "Depends on what you want to change it into.";
        }
    }
}
