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
using System.Windows.Shapes;
using static practos4.Page2;

namespace practos4
{
 
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
         
        }

        private void MainWind_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            if (Page2.human.Count > 0)
            {

                Page.Content = new Page1(Page2.human[0]);
            }
            else
            {
                Page.Content = new Page3();
            }
        }

        private void Redact_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new Page2();
        }
    }
}
