using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    interface IRecord
    {
        string Question { get; set; }
        int ID { get; set;}
        DateTime TimeAsked { get; set; }
        string Answer { get; set; }
        DateTime TimeAnswered { get; set; }
    }
}
