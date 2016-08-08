using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    class Program
    {
        static void Main(string[] args)
        {
            IStore myStore = new InMemoryStore();
            IMessageListener myListener = new QuestionMessageListener(myStore);
            
            IMessageEmitter emitter = new MessageEmitter();
            emitter.Add(myListener);
            emitter.Start();
        }
    }
}
