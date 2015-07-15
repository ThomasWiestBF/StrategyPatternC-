using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class AModule : IModule
    {
        protected String ModuleName;

        public String getName()
        {
            return this.ModuleName;
        }
    }
}
