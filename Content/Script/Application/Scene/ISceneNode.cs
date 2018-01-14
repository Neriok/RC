using Rc.Application.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Scene
{
    public interface ISceneNode
    {
        ISceneController SceneController { get; }
    }
}
