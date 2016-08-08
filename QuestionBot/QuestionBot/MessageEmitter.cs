using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    class MessageEmitter : IMessageEmitter
    {
        private string _lineInput = "";
        private List<IMessageListener> _listeners = new List<IMessageListener>();

        public void Start()
        {
            while (_lineInput!="exit")
            {
                _lineInput = Console.ReadLine();
                NotifyListener(_lineInput);
            }
        }

        public void Add(IMessageListener newListener)
        {
            _listeners.Add(newListener);
        }

        public void NotifyListener(string newInput)
        {
            for (int i = 0; i < _listeners.Count(); i++)
            {
                _listeners[i].ReceiveMessage(newInput);
            }
        }
    }
}
