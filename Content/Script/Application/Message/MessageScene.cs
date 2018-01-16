using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuestionSceneController")]
namespace Rc.Application.Message
{
    public class MessageScene : Node, IControllableScene
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        internal SceneController _controller;

        // --------------------------------------------------
        // Node
        // --------------------------------------------------

        public override void _Ready()
        {

        }

        // --------------------------------------------------
        // ISControllableScene
        // --------------------------------------------------

        public SceneController SceneController
        {
            get { return _controller; }
        }
    }
}