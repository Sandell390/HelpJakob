using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public abstract class MessageManager
    {
        private HTMLConverter htmlConverter = new HTMLConverter();
        public virtual void SendMessage(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = htmlConverter.ConvertBodyToHTML(m.Body);
        }
    }
}
