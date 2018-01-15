using Godot;
using Rc.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Game
{    
    public class QuestionSceneController : SceneController
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private Question _question;
        
        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public QuestionSceneController(PackedScene scene, Question question)
            : this(scene.Instance() as QuestionScene, question)
        {            
        } 

        public QuestionSceneController(QuestionScene scene, Question question)
            : base(scene)
        {                   
            scene._controller = this;
            _question = question;
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
