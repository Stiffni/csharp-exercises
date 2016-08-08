using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBot
{
    interface IMessageEmitter
    {
        void Add(IMessageListener listen);
        void Start();
    }
}
