using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    class QuestionMessageListener: IMessageListener
    {
        private IStore questionDataStore;

        public QuestionMessageListener(IStore store)
        {
            questionDataStore = store;
        }

        public void ReceiveMessage(string input)
        {
            if (input.StartsWith("/question"))
            {
                string questionText = input.Remove(0, 9);

                if (!String.IsNullOrWhiteSpace(questionText))
                {
                    IRecord newQuestion = questionDataStore.CreateRecord(questionText);
                    Console.WriteLine("Question has been created with ID " + newQuestion.ID + ". Question: " +
                       newQuestion.Question);
                }
                else
                {
                    Console.WriteLine("This question appears to be blank, please retry.");
                }
                
            } 
            else if (input.StartsWith("/answer"))
            {
                int firstIDTag;
                int secondIDTag;
                char[] openSquareBrace = {'['};
                char[] closeSquareBrace = {']'};

                string answerWithID = input.Remove(0, 9);

                firstIDTag = answerWithID.IndexOfAny(openSquareBrace, 0);
                secondIDTag = answerWithID.IndexOfAny(closeSquareBrace, 0);

                int questionID = Convert.ToInt32(answerWithID.Substring(firstIDTag + 1, secondIDTag));
                string answer = answerWithID.Remove(0, secondIDTag+1);
                IRecord updatedRecord = questionDataStore.UpdateRecord(questionID, answer);

                Console.WriteLine("Question ID " + updatedRecord.ID + " has been updated with answer: " +
                                  updatedRecord.Answer);
            }
        
        }
    }
}
