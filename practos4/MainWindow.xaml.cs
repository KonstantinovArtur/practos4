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

namespace practos4
{
   
    public partial class MainWindow : Window
    {
        string x = "123";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Click(object sender, RoutedEventArgs e)
        {

          Window1 window1 = new Window1();
            window1.Show();
            Close();

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Text1.Text == x)
            {
                Window1 window1 = new Window1();
                window1.Show();
                window1.Redact.IsEnabled = true;
                Close();
            } 
        }

        private void Text2_Click(object sender, RoutedEventArgs e)
        {
            Text1.IsEnabled = true;
            
        }
    }
}
