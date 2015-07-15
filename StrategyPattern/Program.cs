using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.ExecutionTypes;
using StrategyPattern.Modules;
using StrategyPattern.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Cronjob cron = new Cronjob();
            cron.setModule(new Accounts());
            cron.setTask(new DeleteEntity());
            cron.executeTask();
            Console.WriteLine("\n");
            Workflow wf = new Workflow();
            wf.setModule(new Contacts());
            wf.setTask(new CreateEntity());
            wf.executeTask();
            Console.WriteLine("\n");
            Webservice ws = new Webservice();
            ws.setModule(new Contacts());
            ws.setTask(new CreateEntity());
            ws.executeTask();

            Console.ReadLine();
        }
    }
}
