using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;

namespace Quartz.QuickStart
{
    /// <summary>
    /// This job is scheduled programmatically.
    /// </summary>
    public class ScheduleJob : IJob
    {
        ILog log = LogManager.GetLogger(typeof(ScheduleJob));

        public void Execute(IJobExecutionContext context)
        {
            log.Info("ScheduleJob Executing");
            //Console.WriteLine("ScheduleJob Executing");
        }
    }
}