using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba1Ex2
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

        private void testbuttom_Click(object sender, RoutedEventArgs e)
        {
            string line = testinput.Text;
            line = line.Replace(",", " y:");
            line = "x:" + line;
            formattedText.Text = line;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                line = line.Replace(",", " y:");
                line = "x:" + line + "\n";
                formattedText.Text += line;
            } 
        }
    }
}
