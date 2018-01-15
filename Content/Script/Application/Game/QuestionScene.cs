﻿using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("QuestionSceneController")]
namespace Rc.Application.Game
{
    public class QuestionScene : Node2D, IControllableScene
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        internal SceneController _controller;     

        // --------------------------------------------------
        // Node2D
        // --------------------------------------------------

        public override void _Ready()
        {
            
        }

        // --------------------------------------------------
        // ISceneNode
        // --------------------------------------------------

        public SceneController SceneController
        {
            get
            {
                return _controller;
            }
        }

    }
}




