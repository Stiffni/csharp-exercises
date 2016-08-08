using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    interface IStore
    {
        IRecord CreateRecord(string question);
        IRecord UpdateRecord(int id, string answer);
        IEnumerable<IRecord> GetRecords();
        void DeleteRecord(int id);
    }
}
