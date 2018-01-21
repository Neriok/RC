using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
{
    public class MainScene : Node
    {
        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public override void _Ready()
        {
            Application.Run(this);
        }        

        public override void _Notification(int what)
        {
            if(what == MainLoop.NOTIFICATION_WM_QUIT_REQUEST)
            {
                Application.QuitRequest();
            }
        }       
    }
}


