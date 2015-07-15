using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tasks
{
    class DeleteEntity : ATask
    {
        public DeleteEntity()
        {
            this.TaskName = "DeleteEntity";
        }
    }
}
