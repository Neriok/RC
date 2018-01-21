using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
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
        // Methods
        // --------------------------------------------------

        public abstract Node InitScene(NodePath path = null);
    }

    public abstract class SceneController<TModel> : SceneController
        where TModel : class
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        protected TModel _data;

        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        public TModel Data
        {
            get { return _data; }
        }

        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public SceneController(Node scene, TModel data)
            : base(scene)
        {
            _data = data;
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------
        
        public abstract void BindData(TModel data);
    }
}
