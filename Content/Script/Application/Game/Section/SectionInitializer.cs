using Godot;
using Rc.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.Application.Game.Section
{
    public abstract class SectionInitializer
    {
        protected DbObject _entity;
        protected PackedScene _scene;

        public SectionInitializer(DbObject entity, PackedScene packedScene)
        {
            _entity = entity;
            _scene = packedScene;
        }

        public abstract Node InitNode();
        
    }
}
