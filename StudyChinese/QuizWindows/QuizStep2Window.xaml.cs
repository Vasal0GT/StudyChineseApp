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
using StudyChinese.QuizBack.Models;
using StudyChinese.QuizWindows;
using Table = StudyChinese.QuizBack.Models.Table;

namespace StudyChinese.QuizWindows
{
    /// <summary>
    /// Interaction logic for QuizStep2Window.xaml
    /// </summary>
    public partial class QuizStep2Window : Window
    {
        private Border _selectedTheme;
        Table _table;
        public QuizStep2Window(Table table)
        {
            _table = table;
            InitializeComponent();

            Loaded += QuizStep2Window_Loaded;
        }

        private async void QuizStep2Window_Loaded(object sender, RoutedEventArgs e)
        {
            await AddThemes();
        }
        private async Task AddThemes()
        {
            stackPanelWithThemes.Children.Clear();
            for (int i = 0; i < _table.RowNumber; i++)
            {
                Border br = new Border
                {
                    Style = (Style)FindResource("ThemeCard"),
                    Tag = i
                };

                br.MouseLeftButtonDown += ThemeBorder_MouseLeftButtonDown;

                StackPanel panel = new StackPanel();

                TextBox tx = new TextBox
                {
                    Text = $"Theme {i + 1}",
                    FontWeight = FontWeights.SemiBold,
                    Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333")),
                    Background = Brushes.Transparent,
                    BorderThickness = new Thickness(0)
                };
                panel.Children.Add(tx);
                TextBlock tx2 = new TextBlock 
                {
                    Text = "0 вопросов",
                    FontSize = 12,
                    Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666666"))
                };
                panel.Children.Add(tx2);
                br.Child = panel;

                stackPanelWithThemes.Children.Add(br);
            }
        }
        private void ThemeBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //сюда бахнуть тригер и метод чтоб вопросы справа менялись


            // Сбрасываем прошлый выбор
            if (_selectedTheme != null)
                _selectedTheme.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFD2D2"));

            // Устанавливаем новую выбранную
            var border = sender as Border;
            border.Background = new SolidColorBrush(Color.FromRgb(200, 230, 255)); // голубоватая подсветка
            _selectedTheme = border;
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            QuizStep1Window quizStep1Window = new QuizStep1Window();
            quizStep1Window.Show();
            this.Close();
        }
    }
}
