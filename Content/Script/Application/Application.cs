using Godot;
using Rc.Data.Model;
using Rc.Data.Database;
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

        private static MainScene _mainScene;

        private static Boolean _isRunningApplication;
        private static Boolean _isRunningGame;
        private static Boolean _isRunningEditor;
                
        // --------------------------------------------------
        // Properties
        // --------------------------------------------------

        /// <summary>
        /// Gets the main scene
        /// </summary>
        public static MainScene MainScene
        {
            get { return _mainScene; }
        }

        /// <summary>
        /// Return true if the app is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningApplication
        {
            get { return _isRunningApplication; }
        }

        /// <summary>
        /// Return true if the game is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningGame
        {
            get { return _isRunningGame; }
        }

        /// <summary>
        /// Return true if the editor is running, false otherwise.
        /// </summary>
        public static Boolean IsRunningEditor
        {
            get { return _isRunningEditor; }
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        /// <summary>
        /// Runs application with an initial node.
        /// </summary>
        public static void Run(MainScene mainScene)
        {
            // Make sure application is not initialized
            if (IsRunningApplication)
            {
                // ERROR
                return;
            }
                      

            _isRunningApplication = true;

            // Apply changes to SceneTree

            _mainScene = mainScene;
            MainScene.GetTree().SetAutoAcceptQuit(false); // Allows handle quit requests

            // Instance SceneLoader

            // Setup system message handler (popup)

            // ...

            // Initialize and test database}


            GD.print("Iniciando escena principal!");
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
            if (IsRunningGame)
            {
                // Verify game state
                

            }

            if (IsRunningEditor)
            {
                // Verify editor state

            }

           
            Viewport root = MainScene.GetTree().GetRoot();
            GD.print(root.GetName());

            // Load new main scene.
            PackedScene ps = (PackedScene)ResourceLoader.Load("res://Content/Scene/Main.tscn") ;
            Node n = ps.Instance();


            _isRunningApplication = false;
            root.AddChild(n);

            GD.print(root.GetChildCount());
           

            // Init main script again.
            //root.AddChild(newMainScene);
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
         
            MainScene.GetTree().Quit();
        }

    }
}
