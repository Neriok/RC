using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Message
{
    public class MessageSceneController : SceneController
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private MessageSettings _settings;

        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public MessageSceneController(PackedScene scene, MessageSettings settings)
            : this(scene.Instance() as MessageScene, settings)
        {
        }

        public MessageSceneController(MessageScene scene, MessageSettings settings)
            : base(scene)
        {
            scene._controller = this;
            _settings = settings;
        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------



        // --------------------------------------------------
        // SceneController
        // --------------------------------------------------

        public override Node InitScene()
        {
            return Scene;
        }
    }
}
