using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application
{
    public class MainScene : Node, IControllableScene
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        internal SceneController _controller;

        // --------------------------------------------------
        // Node2D
        // --------------------------------------------------

        public override void _Ready()
        {
            //_controller = new MainSceneController(this);
            //((MainSceneController)_controller).Main();
        }

        public override void _Notification(int what)
        {
            //((MainSceneController)_controller).Notification(what);
        }

        // --------------------------------------------------
        // IControllableScene
        // --------------------------------------------------

        public SceneController SceneController
        {
            get { return _controller; }
        }
		
		
		private void _on_Button_button_down()
		{
		    Application.Reset();
		}

    }
}


