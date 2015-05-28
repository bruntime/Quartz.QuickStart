using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz.Impl;

namespace Quartz.QuickStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Turn On Logging programmatically. Else configure in App.config.
            //Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter { Level = Common.Logging.LogLevel.Info };
            RunMyJobs();
        }

        /// <summary>
        /// http://www.quartz-scheduler.org/documentation/quartz-1.x/tutorials/crontrigger
        /// http://quartz-scheduler.org/documentation/quartz-2.x/configuration/
        /// http://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html
        /// </summary>
        public static void RunMyJobs()
        {
            try
            {
                ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
                IScheduler scheduler = schedulerFactory.GetScheduler();

                IJobDetail jobDetail = JobBuilder.Create<ScheduleJob>()
                    .WithIdentity("MyTestScheduleJob")
                    .Build();

                ITrigger trigger = TriggerBuilder.Create()
                    .ForJob(jobDetail)
                    .WithCronSchedule("0/5 * * * * ?")
                    .WithIdentity("MyTestTrigger")
                    .StartNow()
                    .Build();

                scheduler.ScheduleJob(jobDetail, trigger);

                scheduler.Start();
            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }
    }
}