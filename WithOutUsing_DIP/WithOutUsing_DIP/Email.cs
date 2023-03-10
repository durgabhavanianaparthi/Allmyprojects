using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOutUsing_DIP
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            Console.WriteLine("Send email");
        }
    }
    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            Console.WriteLine("Send Sms");
        }
    }
    public class Notification
    {
        public Email _email;
        public SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }
        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }


}
