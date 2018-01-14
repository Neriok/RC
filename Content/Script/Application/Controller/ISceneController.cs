using Godot;
using Rc.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Controller
{
    public interface ISceneController
    {
        /// <summary>
        /// Gets the scene linked with the controller.
        /// </summary>
        Node Scene { get; }

        /// <summary>
        /// Initializes the scene and add it to the path.
        /// </summary>
        Node InitScene(NodePath path = null);
    }
}
