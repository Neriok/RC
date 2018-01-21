using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
{
    public static class Message
    {
        // --------------------------------------------------
        // Methods
        // --------------------------------------------------      

        public static MessageResult Show(String text, String caption = "", MessageButtons messageButtons = MessageButtons.Accept, 
                                         MessageIcon messageIcon = MessageIcon.None,
                                         MessageDefaultButton messageDefaultButton = MessageDefaultButton.Button1)
        {
            MessageSceneController msc = new MessageSceneController(
                ResourceLoader.Load("res://Content/Scene/Message.tscn") as PackedScene,
                new MessageSettings { Text = text, Caption = caption, MessageButtons = messageButtons,
                MessageIcon = messageIcon, MessageDefaultButton = messageDefaultButton }
            );

            msc.InitScene("root/Main");
            Application.RunMessage(msc);

            return msc.MessageResult;        
        }
    }
}
