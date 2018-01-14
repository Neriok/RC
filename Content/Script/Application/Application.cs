using Godot;
using Rc.Data.Model;
using Rc.Data.Database;
using Rc.Application.Game.Section;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application
{
    public static class Application
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        //private static SceneHandler _sceneHandler;
        private static Node _mainNode;

        private static Godot.Object _game;
        private static Godot.Object _editor;

        private static Boolean _isRunningApplication;
        private static Boolean _isRunningGame;
        private static Boolean _isRunningEditor;
                
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets the main node (init node)
        /// </summary>
        public static Node MainNode
        {
            get
            {
                return _mainNode;
            }
        }

        /// <summary>
        /// Return true if the app is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningApplication
        {
            get
            {
                return _isRunningApplication;
            }
        }

        /// <summary>
        /// Return true if the game is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningGame
        {
            get
            {
                return _isRunningGame;
            }
        }

        /// <summary>
        /// Return true if the editor is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningEditor
        {
            get
            {
                return _isRunningEditor;
            }
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
        /// Runs application with an initial node.
        /// </summary>
        public static void Run(Node mainNode)
        {
            // Make sure application is not initialized
            if (IsRunningApplication)
            {
                // ERROR
                return;
            }

            _isRunningApplication = true;

            // Apply changes to SceneTree

            _mainNode = mainNode;
            MainNode.GetTree().SetAutoAcceptQuit(false); // Allows handle quit requests

            // Instance SceneLoader

            // Setup system message handler (popup)

            // ...

            // Initialize and test database}

            Question q = new Question();
            q.Caption = "NADIE PASA DE ESTA ESQUINA, AQUI MANDAN LAS DIVINAS";

            QuestionInitializer qi = new QuestionInitializer(q, ResourceLoader.Load("res://Content/Scene/Node2D.tscn") as PackedScene);
            

            MainNode.AddChild(qi.InitNode());

        }

        public static void RunGame()
        {
            if (IsRunningGame)
            {
                // ERROR
                return;
            }

            _isRunningGame = true;
        }

        public static void RunEditor()
        {
            if (IsRunningEditor)
            {
                // ERROR
                return;
            }

            _isRunningEditor = true;
        }

        private static Boolean InitDatabase(String databasePath)
        {
            return InitDatabase(new RcDatabase());
        }
        
        private static Boolean InitDatabase(RcDatabase database)
        {
            return true;
        }

        public static void Reset()
        {

        }

        public static void QuitRequest()
        {
            if (IsRunningGame)
            {
                // Verify game state

                //if (Game.QuitRequest())
                //    return;
              
                   
            }

            if (IsRunningEditor)
            {
                // Verify editor state

                //if (Editor.QuitRequest())
                //    return;
            }
         
            MainNode.GetTree().Quit();
        }

    }
}
