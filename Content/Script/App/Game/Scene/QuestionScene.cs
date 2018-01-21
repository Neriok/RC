using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Rc.App.Game.Scene
{
    public class QuestionScene : Node2D, IControllableScene
    {
        // --------------------------------------------------
        // Node2D
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




