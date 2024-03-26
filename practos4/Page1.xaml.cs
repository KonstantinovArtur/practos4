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
using static practos4.Page2;
using static System.Net.Mime.MediaTypeNames;

namespace practos4
{

    public partial class Page1 : Page
    {
        private Human selectedHuman;

        public Page1(Human human)
        {
            InitializeComponent();
            selectedHuman = human;


            Txt.Text = selectedHuman.Name;
            Button1.Content = selectedHuman.FirstAnswer;
            Button2.Content = selectedHuman.SecondAnswer;
            Button3.Content = selectedHuman.ThirdAnswer;

            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
        }



        public void Button1_Click(object sender, RoutedEventArgs e)
        {
            Txt2.Text = "Ваш ответ: " + Button1.Content;
            CheckAnswer(Button1.Content.ToString());
        }

        public void Button2_Click(object sender, RoutedEventArgs e)
        {
            Txt2.Text = "Ваш ответ: " + Button2.Content;
            CheckAnswer(Button2.Content.ToString());
        }

        public void Button3_Click(object sender, RoutedEventArgs e)
        {
            Txt2.Text = "Ваш ответ: " + Button3.Content;

            CheckAnswer(Button3.Content.ToString());
        }

        private void CheckAnswer(string selectedAnswer)
        {
            if (selectedAnswer == selectedHuman.RightAnswer)
            {
                MessageBox.Show("Правильно");
            }
            else
            {
                MessageBox.Show("Неправильно");
            }
        }
    }
}
