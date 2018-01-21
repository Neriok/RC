using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rc.App
{
    public interface IMessageResult
    {
        void SetResult(MessageResult messageResult);

        Boolean HasResult();
    }
}
