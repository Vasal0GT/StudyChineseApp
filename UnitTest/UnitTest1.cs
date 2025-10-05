using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyChinese.QuizBack.Models;
using System.Diagnostics;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext _testContext { get; set; }
        [TestMethod]
        public void ConvertToJson_CreatedAndExisted_resulTrue()
        {
            QuestionDTO question1 = new QuestionDTO();
            question1.Guess = "1 + 1？";
            question1.Answer = "2";
            question1.Row = 0;
            question1.Column = 0;
            Table table = new Table();
            table.ColumnNumber = 2;
            table.RowNumber = 3;
            table.Name = "Name";
            table.Description = "Description";
            //table.Questions
            table.ConvertToJson(table, "test1");

            var result = File.Exists(@"C:\VA\chineseApp\StudyChinese\StudyChinese\QuizBack\JsonTables\test1.json");
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ConvertStringToQuestionDTO_CreatedCorrectDTO_resultTrue()
        {
            QuestionDTO questionTamplate = new QuestionDTO();
            questionTamplate.ConnectedTable = "main";
            questionTamplate.Guess = "1 + 1?";
            questionTamplate.Answer = "2";
            questionTamplate.Row = 0; 
            questionTamplate.Column = 0;

            string forConverting = "main/1 + 1?/2/0/0/";

            QuestionDTO result = QuestionDTO.ConvertStringToQuestionDTO(forConverting);

            Assert.IsTrue(questionTamplate.Equals(result));
        }
    }
}
