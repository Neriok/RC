using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application
{
    public abstract class SceneController : IScene
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        protected Node _scene;

        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        public Node Scene
        {
            get { return _scene; }
        }

        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public SceneController(Node scene)
        {
            _scene = scene;
        }

        // --------------------------------------------------
        // Methods [Abstract]
        // --------------------------------------------------

        public abstract Node InitScene();
    }
}
