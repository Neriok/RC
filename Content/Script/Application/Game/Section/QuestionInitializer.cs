using Rc.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Godot;

namespace Rc.Application.Game.Section
{
    public class QuestionInitializer : SectionInitializer
    {

        public QuestionInitializer(Question question, PackedScene packedScene)
            : base(question, packedScene)
        {
            // ...
        }

        public override Node InitNode()
        {
            Node result = _scene.Instance();

            Label l = result.GetChild(0) as Label;
            l.Text = ((Question)_entity).Caption;

            

            return result;
        }

    }
}
