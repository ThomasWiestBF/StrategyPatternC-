using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class AExecutionType : IExecutionType
    {
        protected ITask myTask;
        protected IModule myModule;
        protected String myExecutionType;

        public void setTask(ITask Task)
        {
            this.myTask = Task;
        }

        public void setModule(IModule Module)
        {
            this.myModule = Module;
        }

        public void executeTask()
        {
            Console.WriteLine("Executing From " + myExecutionType);
            this.myTask.executeTask(this.myModule);
        }
    }
}
