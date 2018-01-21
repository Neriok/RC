using Godot;
using Rc.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App.Game.Scene
{    
    public class QuestionSceneController : SceneController<Question>
    {        
        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------        

        public QuestionSceneController(QuestionScene scene, Question question)
            : base(scene, question)
        {                   
            scene.SceneController = this;
        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------



        // --------------------------------------------------
        // SceneController
        // --------------------------------------------------
        
        public override Node InitScene(NodePath path = null)
        {
            return Scene;
        }

        // --------------------------------------------------
        // SceneController <Question>
        // --------------------------------------------------

        public override void BindData(Question data)
        {
            throw new NotImplementedException();
        }
    }
}
