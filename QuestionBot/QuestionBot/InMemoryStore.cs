using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    class InMemoryStore : IStore
    {
        DateTime _currentDateTime;
        private List<IRecord> allRecords = new List<IRecord>();
        private int _questionId = 0;

        public IRecord CreateRecord(string question)
        {
            _currentDateTime = DateTime.Now;
            _questionId++;

            Record newQuestion = new Record(_questionId, question, _currentDateTime);
            allRecords.Add(newQuestion);

            return newQuestion;
        }

        public IRecord UpdateRecord(int id, string answer)
        {
            _currentDateTime = DateTime.Now;
            IRecord recordToUpdate = allRecords.FirstOrDefault(recordItem => recordItem.ID == id);
            
            recordToUpdate.Answer = answer;
            recordToUpdate.TimeAnswered = _currentDateTime;

            return recordToUpdate;
        }

        public IEnumerable<IRecord> GetRecords()
        {
            return allRecords;
        }

        public void DeleteRecord(int id)
        {

        }
    }
}
