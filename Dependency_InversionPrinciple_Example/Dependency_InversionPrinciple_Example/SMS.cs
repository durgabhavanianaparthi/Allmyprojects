using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple_Example
{
   public  class SMS: IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Send Sms from sms Class");
        }
    }
}
