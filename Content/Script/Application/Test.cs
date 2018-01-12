using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace Rc.Application
{
    public class Test : Control
    {
        public override void _Ready()
        {
           Application.Run(this);
           GetTree().SetAutoAcceptQuit(false);
            
        }

        public override void _Notification(Int32 what)
        {
            if (what == MainLoop.NOTIFICATION_WM_QUIT_REQUEST)
            {
                GD.print("Adios :C");
				
				Application.QuitRequest();
            }
        }

        private void _on_Control_tree_exited()
	    {
		    GD.print("AUN NO ESCAPARAS!");
    	    // Replace with function body
	    }
	

    }
}


