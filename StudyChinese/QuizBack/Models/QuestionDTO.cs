using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyChinese.QuizBack.Models
{
    public class QuestionDTO : IEquatable<QuestionDTO>
    {
        public string ConnectedTable { get; set; }
        public string Guess { get; set; }
        public string Answer { get; set; }
        public int Column { get; set; }
        public int Row  { get; set; }

        public QuestionDTO(string guess, string answer, int column, int row, string connectedTable)
        {
            Guess = guess;
            Answer = answer;
            Column = column;
            Row = row;
            ConnectedTable=connectedTable;
        }
        public QuestionDTO()
        { 
        }

        public bool Equals(QuestionDTO other)
        {
            if (other is null) return false;

            return ConnectedTable == other.ConnectedTable &&
               Guess == other.Guess &&
               Answer == other.Answer &&
               Row == other.Row &&
               Column == other.Column;

        }

        public override bool Equals(object obj) => Equals(obj as QuestionDTO);

        public string ConvertQuestionDTOToString(QuestionDTO questionDTO)
        {
            return questionDTO.ConnectedTable + "/" + questionDTO.Guess + "/" + questionDTO.Answer + "/" + questionDTO.Column + "/" + questionDTO.Row + "/";
        }
        public static QuestionDTO ConvertStringToQuestionDTO(string str)
        {
            QuestionDTO questionDTO = new QuestionDTO();
            int index = 0;
            int startIndex = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/')
                {
                    switch (index)
                    {
                        case 0:
                            questionDTO.ConnectedTable = str.Substring(startIndex, i);
                            break;
                        case 1:
                            questionDTO.Guess = str.Substring(startIndex, i);
                            break;
                        case 2:
                            questionDTO.Answer = str.Substring(startIndex, i);
                            break;
                        case 3:
                            questionDTO.Column = int.Parse(str.Substring(startIndex, i));
                            break;
                        case 4:
                            questionDTO.Row = int.Parse(str.Substring(startIndex, i));
                            break;
                    }
                    index++;
                    startIndex = i;
                }
            }
            return questionDTO;
        }
    }
}
