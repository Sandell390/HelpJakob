using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public abstract class MessageManager
    {
        public HTMLConverter htmlConverter = new HTMLConverter();
        public abstract void SendMessage(Message m, bool isHTML);
    }
}
