using Godot;
using Rc.Application.Controller;
using Rc.Application.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuestionSceneController")]
namespace Rc.Application.Game
{
    public class QuestionScene : Node2D, ISceneNode
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        internal ISceneController _controller;     

        // --------------------------------------------------
        // Node2D
        // --------------------------------------------------

        public override void _Ready()
        {
            
        }

        // --------------------------------------------------
        // ISceneNode
        // --------------------------------------------------

        public ISceneController SceneController
        {
            get
            {
                return _controller;
            }
        }

    }
}




