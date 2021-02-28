using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationDemo.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Subject { get; set; }
        public string MessageText { get; set; }
        public bool MessageStatus { get; set; }
    }
}
