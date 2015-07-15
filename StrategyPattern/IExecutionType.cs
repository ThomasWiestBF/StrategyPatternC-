using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IExecutionType
    {
        void setTask(ITask Task);
        void executeTask();
        void setModule(IModule Module);
    }
}
