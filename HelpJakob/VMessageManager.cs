using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob
{
    public class VMessageManager : MessageManager
    {
        public override void SendMessage(Message m, bool isHTML)
        {
            if (isHTML)
                m.Body = htmlConverter.ConvertBodyToHTML(m.Body);
        }
    }
}
