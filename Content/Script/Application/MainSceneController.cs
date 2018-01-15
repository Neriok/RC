using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application
{
    public class MainSceneController : SceneController
    {
        // --------------------------------------------------
        // Constructor
        // --------------------------------------------------

        public MainSceneController(MainScene scene)
            : base(scene)
        {            
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public void Main()
        {
            Application.Run((MainScene)_scene);
        }

        public void Notification(Int32 what)
        {
            if(what == MainLoop.NOTIFICATION_WM_QUIT_REQUEST)
            {
                Application.QuitRequest();
            }
        }        

        // --------------------------------------------------
        // SceneController
        // --------------------------------------------------
                
        public override Node InitScene()
        {         
            // Nothing to do here
            return _scene;
        }
    }
}
