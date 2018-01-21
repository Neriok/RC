using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App.Menu.Scene
{
    public class MenuSceneController : SceneController
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------

        private SettingSceneController _settingsSceneController;

        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------

        public MenuSceneController(MenuScene scene)
            : base(scene)
        {
            scene._controller = this;
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public void ShowSettings()
        {

        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------
        
        public void OnGameButtonDown()
        {

        }

        public void OnEditorButtonDown()
        {

        }

        public void OnSettingsButtonDonw()
        {

        }

        public void OnExitButtonDown()
        {
            Application.QuitRequest();
        }

        // --------------------------------------------------
        // SceneController
        // --------------------------------------------------

        public override Node InitScene(NodePath path = null)
        {
            return Scene;
        }
    }
}
