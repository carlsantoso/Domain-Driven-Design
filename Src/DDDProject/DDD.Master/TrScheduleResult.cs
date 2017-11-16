using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master
{
    public class TrScheduleResult
    {
        public int PeriodId { get; set; }

        public int ScheduleId { get; set; }

        public int CourseId { get; set; }

        public DateTime ScheduledStart { get; set; }

        public DateTime ScheduledEnd { get; set; }

        public int EmployeeId { get; set; }

        public int LocationId { get; set; }

        public ICollection<TrScheduleResultDetail> ScheduleResultDetails { get; set; }

        public virtual MsEmployee Trainer { get; set; }

        public virtual MsLocation Location { get; set; }

        public virtual MsCourse Course { get; set; }

        public virtual MsPeriod Periode { get; set; }
    }
}
