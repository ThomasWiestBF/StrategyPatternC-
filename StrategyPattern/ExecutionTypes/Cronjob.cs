using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ExecutionTypes
{
    class Cronjob : AExecutionType
    {
        public Cronjob()
        {
            this.myExecutionType = "Cronjob";
        }
    }
}
