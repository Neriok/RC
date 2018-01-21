using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
{
    public struct MessageSettings
    {
        public String Text { get; set; }

        public String Caption { get; set; }

        public MessageButtons MessageButtons { get; set; }

        public MessageIcon MessageIcon { get; set; }        

        public MessageDefaultButton MessageDefaultButton { get; set; }

    }
}
