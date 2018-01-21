using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MessageSceneController")]
namespace Rc.App
{
    public class MessageScene : Node, IControllableScene
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        internal SceneController _controller;

        // --------------------------------------------------
        // ISControllableScene
        // --------------------------------------------------

        public SceneController SceneController
        {
            get { return _controller; }
        }

        // --------------------------------------------------
        // Node
        // --------------------------------------------------

        public override void _Ready()
        {
            Button btn = this.GetNode("Box/ButtonsContainer/NoneButton") as Button;
            btn.Text = "Cancel";
            btn.Connect("button_down", this, "OnAnyButtonDown", new object[] { MessageResult.Cancel });

            Button btnAccept = btn.Duplicate() as Button;            
            this.GetNode("Box/ButtonsContainer").AddChild(btnAccept);
            btnAccept.SetName("AcceptButton");
            btnAccept.Text = "Accept";
            btnAccept.RectPosition = new Vector2(btn.GetRect().Position.x - 120, btn.GetRect().Position.y);
            btnAccept.Connect("button_down", this, "OnAnyButtonDown", new object[] { MessageResult.Accept });
        }	
        
        private void OnAnyButtonDown(MessageResult messageResult)
        {
            ((MessageSceneController)_controller).OnAnyButtonDown(messageResult);
        }


        private void OnLostFocus()
        {
            ((MessageSceneController)_controller).OnLostFocus();
        }
    }
}


