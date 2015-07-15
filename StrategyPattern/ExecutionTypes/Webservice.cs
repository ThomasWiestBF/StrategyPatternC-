using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ExecutionTypes
{
    class Webservice : AExecutionType
    {
        public Webservice()
        {
            this.myExecutionType = "Webservice";
        }
    }
}
