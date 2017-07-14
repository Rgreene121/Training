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

namespace WpfAppPrac1
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

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          //  MessageBox.Show("How are you today");

            string words = ME.Text;
            //labelText.Content = words;
        
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            Second sec = new Second();
            sec.ShowDialog();

        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            Second go = new Second();
            go.ShowDialog();
        }
    }
}
