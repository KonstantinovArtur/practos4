using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace practos4
{

    public partial class Page2 : Page
    {





            public static List<Human> human = new List<Human>()
            {
                new Human("Сколько будет 99+13*5:3=", "ответ 6", "134.7", "120.6", "109.3", "120.6")


            };
        public Page2()
        {
            InitializeComponent();
            

            dataGrid.ItemsSource = human;
           

        }
        public class Human
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string FirstAnswer { get; set; }
            public string SecondAnswer { get; set; }
            public string ThirdAnswer { get; set; }
            public string RightAnswer { get; set; }

            public Human(string name, string description, string firstAnswer, string secondAnswer, string thirdAnswer, string rightAnswer)
            {
                Name = name;
                Description = description;
                FirstAnswer = firstAnswer;
                SecondAnswer = secondAnswer;
                ThirdAnswer = thirdAnswer;
                RightAnswer = rightAnswer;
            }
        }

    }


}
