using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Message
{
    public static class Message
    {
        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public static MessageResult Show(String text, String caption, MessageButtons messageButtons, 
                                         MessageIcon messageIcon, MessageDefaultButton messageDefaultButton)
        {
            return ShowInternal(text, caption, messageButtons, messageIcon, messageDefaultButton);
        }
        
        public static MessageResult Show(String text)
        {
            return ShowInternal(text, String.Empty, MessageButtons.Accept, MessageIcon.None, MessageDefaultButton.Button1);
        }

        private static MessageResult ShowInternal(String text, String caption, MessageButtons messageButtons,
                                                  MessageIcon messageIcon, MessageDefaultButton messageDefaultButton)
        {
            return MessageResult.Accept;
        }
    }
}
