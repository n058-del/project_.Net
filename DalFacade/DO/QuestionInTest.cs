using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public record QuestionInTest
    {
        int StudentId;
        int TestId;
        int QuestionId;
        int SelectedAnswerId;
        public QuestionInTest()
        { }
    }
}
