using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master
{
    public class TrScheduleResultDetail
    {
        public int PeriodId { get; set; }

        public int ScheduleId { get; set; }

        public int EmployeeId { get; set; }

        public virtual MsEmployee Participant { get; set; }

        public virtual TrScheduleResult Schedule { get; set; }
    }
}
