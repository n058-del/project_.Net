using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public record Answer
    {
        int Id;
        int QuestionId;
        string? AnswerText;
        public Answer()     
        {

        }
        
    }
}
