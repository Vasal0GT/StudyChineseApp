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
using Newtonsoft.Json;
using StudyChinese.QuizBack.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using Path = System.IO.Path;
using Table = StudyChinese.QuizBack.Models.Table;

namespace StudyChinese.QuizWindows
{
    /// <summary>
    /// Interaction logic for ManagementWindow.xaml
    /// </summary>
    public partial class ManagementWindow : Window
    {
        private readonly string quizFolder;
        public ManagementWindow()
        {
            InitializeComponent();

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            quizFolder = Path.GetFullPath(Path.Combine(baseDir, @"..\..\..\QuizBack\JsonTables"));

            Loaded += QuizChoose_Loaded;
        }
        private async void QuizChoose_Loaded(object sender, RoutedEventArgs e)
        {
            await LoadQuizzesAsync();
        }
        private async Task LoadQuizzesAsync()
        {
            var files = Directory.GetFiles(quizFolder, "*.json");
            Array.Sort(files);

            var quizes = await Task.Run(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    foreach (var file in files)
                    {
                        string json = File.ReadAllText(file);
                        var table = JsonConvert.DeserializeObject<Table>(json);
                        QuizList.DisplayMemberPath = "Name";
                        if (table != null) QuizList.Items.Add(table);
                    }
                });
                return QuizList;
            });
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
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
