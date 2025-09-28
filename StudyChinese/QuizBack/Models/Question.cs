using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyChinese.QuizBack.Models
{
    public class Question
    {
        public string Guess { get; set; }
        public string Answer { get; set; }
        public int Column { get; set; }
        public int Row  { get; set; }

        public Question(string guess, string answer, int column, int row)
        { 
            Guess = guess;
            Answer = answer;
            Column = column;
            Row = row;
        }
    }
}
