using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App.Menu.Scene
{
    public class MenuScene : Node, IControllableScene
    {
        // --------------------------------------------------
        // Node
        // --------------------------------------------------

        public override void _Ready()
        {

        }

        // --------------------------------------------------
        // ISceneNode
        // --------------------------------------------------

        public SceneController SceneController { get; set; }
    }
}
