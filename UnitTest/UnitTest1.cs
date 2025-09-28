using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyChinese.QuizBack.Models;
using System;
using System.IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertToJson_CreatedAndExisted_resulTrue()
        {
            Table table = new Table();
            table.ColumnNumber = 2;
            table.RowNumber = 3;
            table.Name = "Name";
            table.Description = "Description";
            table.ConvertToJson(table, "test1");

            var result = File.Exists(@"C:\VA\chineseApp\StudyChinese\StudyChinese\QuizBack\JsonTables\test1.json");
            Assert.IsTrue(result);
        }
    }
}
