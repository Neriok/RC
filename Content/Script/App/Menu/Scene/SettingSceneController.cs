using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App.Menu.Scene
{
    public class SettingSceneController : SceneController<Settings>
    {
        // --------------------------------------------------
        // Fields
        // --------------------------------------------------
        

        // --------------------------------------------------
        // Constructors
        // --------------------------------------------------
        
        public SettingSceneController(SettingScene scene, Settings settings)
            : base(scene, settings)
        {
            scene.SceneController = this;
        }

        // --------------------------------------------------
        // Methods
        // --------------------------------------------------

        public void SaveSettings()
        {

        }

        // --------------------------------------------------
        // Signals
        // --------------------------------------------------
        
        public void OnApplyButtonDown()
        {

        }

        public void OnAcceptButtonDown()
        {

        }

        public void OnCancelButtonDown()
        {

        }

        // --------------------------------------------------
        // SceneController<Settings>
        // --------------------------------------------------

        public override Node InitScene(NodePath path = null)
        {
            return Scene;
        }

        public override void BindData(Settings data)
        {
            
        }
    }
}
