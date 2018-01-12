using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application
{
    public class SceneLoader
    {
        public static int num = 0;
              

        public static PackedScene AddScene(String resource)
        {
            PackedScene scene = ResourceLoader.Load(resource) as PackedScene;
            return scene;            
        }

    }
}
