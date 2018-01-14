using Godot;
using Rc.Data.Model;
using Rc.Application.Scene;
using Rc.Application.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Rc.Application.Game
{    
    public class QuestionSceneController : ISceneController
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private Question _question;
        private QuestionScene _scene;
        
        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public QuestionSceneController(Question question, PackedScene scene)
            : this(question, scene.Instance() as QuestionScene)
        {            
        }

        public QuestionSceneController(Question question, QuestionScene scene)
        {
           if(scene == null)
            {
                // ERROR
            }

            _scene = scene;
            _scene._controller = this;
            _question = question;

        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------



        // --------------------------------------------------
        // ISceneController
        // --------------------------------------------------
        
        public Node Scene
        {
            get
            {
                return _scene;
            }
        }


        public Node InitScene(NodePath path = null)
        {
            return Scene;
        }
    }
}
