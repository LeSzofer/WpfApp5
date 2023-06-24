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

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigateToPage1();
        }

        private void NavigateToPage1()
        {
            MainFrame.Navigate(new Page1());
        }

        private void NavigateToPage2()
        {
            MainFrame.Navigate(new Page2());
        }

        private void NavigateToPage3()
        {
            MainFrame.Navigate(new Page3());
        }

        private void NavigateToPage4()
        {
            MainFrame.Navigate(new Page4());
        }

        private void ButtonPage1_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage1();
        }

        private void ButtonPage2_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage2();
        }

        private void ButtonPage3_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage3();
        }

        private void ButtonPage4_Click(object sender, RoutedEventArgs e)
        {
            NavigateToPage4();
        }
    }
}
