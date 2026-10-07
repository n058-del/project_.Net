using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public record Question
    {
        int Id;
        enum Subject;
        string QuestionText;
        int CorrectAnswerId;
        public Question()
        { }

    }
}
