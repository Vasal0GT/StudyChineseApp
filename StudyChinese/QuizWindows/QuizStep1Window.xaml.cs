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

namespace StudyChinese.QuizWindows
{
    /// <summary>
    /// Interaction logic for QuizStep1Window.xaml
    /// </summary>
    public partial class QuizStep1Window : Window
    {
        public QuizStep1Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QuizStep2Window quizStep2Window = new QuizStep2Window();
            quizStep2Window.Show();
            this.Close();
        }
    }
}
