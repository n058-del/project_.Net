using System;
using System.Collections.Generic;
using System.Text;

namespace DO
{
    public record StudentInTest
    {
        int StudentId;
        string StudentName;
        int TestId;
        int? Grade;
        public StudentInTest()
        { }
    }
}
