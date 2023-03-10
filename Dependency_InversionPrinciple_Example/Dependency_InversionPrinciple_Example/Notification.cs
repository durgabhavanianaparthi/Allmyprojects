using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple_Example
{
    public class Notification
    {
      public List<IMessage> _messages;
        public Notification(List<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send() 
        {
            foreach (var message in _messages)
            {
              message.SendMessage();
            }
        }
    }
}
