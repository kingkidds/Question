using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Question.Models
{
    public class TestResult
    {
        public int TRId { get; set; }
        public Guid UserId { get; set; }
        public Guid TestTypeId { get; set; }
        public Guid TestSubjectId { get; set; }
        public string UserAnswer { get; set; }
        public DateTime UserTestTime { get; set; }
        public int UserScore { get; set; }
    }
}
