using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
{
    public class MessageSceneController : SceneController
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private MessageSettings _messageSettings;
        private MessageResult _messageResult;

        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        public MessageResult MessageResult
        {
            get { return _messageResult;  }
        }

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
            _messageSettings = settings;
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public Boolean HasResult()
        {
            if(_messageResult != MessageResult.None)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------

        public void OnAnyButtonDown(MessageResult result)
        {

            GD.print(result.ToString());
            _messageResult = result;
            
        }

        public void OnLostFocus()
        {
            _messageResult = MessageResult.Cancel;
        }

        // --------------------------------------------------
        // SceneController
        // --------------------------------------------------

        public override Node InitScene(NodePath path = null)
        {
            Application.MainScene.AddChild(_scene);

            // Setup caption
            ((Label)_scene.GetNode("Box/Caption")).SetText(_messageSettings.Caption);
            ((Label)_scene.GetNode("Box/Text")).SetText(_messageSettings.Text);

            switch (_messageSettings.MessageIcon)
            {
                case MessageIcon.None:

                    break;
            }

            switch(_messageSettings.MessageButtons)
            {
                case MessageButtons.Accept:
                    
                    
                    break;
            }

            return Scene;
        }
    }
}
