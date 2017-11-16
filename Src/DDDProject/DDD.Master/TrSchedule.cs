using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master
{
    public class TrSchedule
    {
        public int PeriodId { get; set; }

        public int ScheduleId { get; set; }

        public int CourseId { get; set; }

        public DateTime ScheduledStart { get; set; }

        public DateTime ScheduledEnd { get; set; }

        public int EmployeeId { get; set; }

        public int TotalParticipant { get; set; }

        public int LocationId { get; set; }

        public int EnrollId { get; set; }

        public DateTime EnrollStart { get; set; }

        public DateTime EnrollEnd { get; set; }

        public virtual MsEmployee Trainer { get; set; }

        public virtual MsLocation Location { get; set; }

        public virtual MsCourse Course { get; set; }

        public virtual MsPeriod Periode { get; set; }
    }
}
