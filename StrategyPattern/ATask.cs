using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class ATask : ITask
    {
        protected String TaskName;
        public void executeTask(IModule Module)
        {
            Console.WriteLine("Executing " + TaskName + " on Module " + Module.getName());
        }
    }
}
