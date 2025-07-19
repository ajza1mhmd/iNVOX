using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invox.Common
{
    class GlobalValues
    {
        public static readonly LogWritter _log = new LogWritter();

        public LogWritter logWritter
        {
            get { return _log; }
        }
    }
}
