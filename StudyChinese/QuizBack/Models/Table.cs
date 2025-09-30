using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyChinese.QuizBack.Models
{
    public class Table
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public List<string> Questions { get; set; }

        public Table(Guid id, string name, string description, int rowNumber, int columnNumber, List<string> questions)
        {
            Id = id;
            Name = name;
            Description = description;
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
            Questions = questions ?? new List<string>();
        }
        public Table()
        { 
        }

        //нужно добавить два метода по сериализации всех полученных значений из экзмепляра лкасса в json 
        public string ConvertToJson(Table table, string tableName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(table);
                string baseDerictory = AppDomain.CurrentDomain.BaseDirectory;
                string projcetDirectory = Path.GetFullPath(Path.Combine(baseDerictory, @"..\..\..\"));

                string folderPath = Path.Combine(projcetDirectory, "QuizBack", "JsonTables");

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, $"{tableName}.json");

                File.WriteAllText(filePath, json);
                return "Викторина была успешно сохранен";
            } catch
            {
                return "Ошибка в создании викторины";
            }
        }
    }
}
