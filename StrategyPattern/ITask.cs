﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface ITask
    {
        void executeTask(IModule Module);
    }
}
