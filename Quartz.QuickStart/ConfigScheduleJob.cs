using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;

namespace Quartz.QuickStart
{
    /// <summary>
    /// This job is scheduled in the quartzjobs.config file.
    /// </summary>
    public class ConfigScheduleJob : IInterruptableJob
    {
        ILog log = LogManager.GetLogger(typeof(ScheduleJob));

        public void Execute(IJobExecutionContext context)
        {
            log.Info("ConfigScheduleJob Executing");
        }

        public void Interrupt()
        {
            log.Info("ConfigScheduleJob Interrupt");
        }
    }
}