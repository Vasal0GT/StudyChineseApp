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
    /// Interaction logic for ManagementWindow.xaml
    /// </summary>
    public partial class ManagementWindow : Window
    {
        public ManagementWindow()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void CreateNewQuiz_Click(object sender, RoutedEventArgs e)
        {
            // Логика создания новой викторины
        }

        private void CreateFirstQuiz_Click(object sender, RoutedEventArgs e)
        {
            // Логика создания первой викторины
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            QuizStep1Window quizStep1Window = new QuizStep1Window();
            quizStep1Window.Show();
            this.Close();
        }

        private void BackButton_Click_1(object sender, RoutedEventArgs e)
        {
            QuizzMain quizzMain = new QuizzMain();
            quizzMain.Show();
            this.Close();
        }
    }
}
