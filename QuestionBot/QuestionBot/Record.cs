using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    class Record : IRecord
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int ID { get; set; }
        public DateTime TimeAsked { get; set; }
        public DateTime TimeAnswered { get; set; }

        public Record(int id, string qstn, DateTime qstnTime)
        {
            Question = qstn;
            TimeAsked = qstnTime;
            ID = id;
        }
    }
}
