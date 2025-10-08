using StudyChinese.QuizBack.Models;
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
    /// Interaction logic for QuestionWindow.xaml
    /// </summary>
    public partial class QuestionWindow : Window
    {
        private QuestionDTO _questionDTO;
        public QuestionWindow(QuestionDTO questionDTO)
        {
            InitializeComponent();
            _questionDTO = questionDTO;
            testGuess.Text = _questionDTO.Guess;
        }
    }
}
