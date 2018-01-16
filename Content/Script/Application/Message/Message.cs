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

        public static MessageResult Show(String text)
        {
            return Show(text, String.Empty, MessageButtons.Accept, MessageIcon.None, MessageDefaultButton.Button1);
        }  

        public static MessageResult Show(String text, String caption)
        {
            return Show(text, caption, MessageButtons.Accept, MessageIcon.None, MessageDefaultButton.Button1);            
        }

        public static MessageResult Show(String text, String caption, MessageButtons messageButtons)
        {
            return Show(text, caption, messageButtons, MessageIcon.None, MessageDefaultButton.Button1);            
        }        
 
        public static MessageResult Show(String text, String caption, MessageButtons messageButtons
                                         MessageIcon mssageIcon)
        {
            return Show(text, caption, messageButtons, messageIcon, MessageDefaultButton.Button1);            
        } 

        public static MessageResult Show(String text, String caption, MessageButtons messageButtons, 
                                         MessageIcon messageIcon, MessageDefaultButton messageDefaultButton)
        {
            return MessageResult.Accept;            
        }   
    }
}
