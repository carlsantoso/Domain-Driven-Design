using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master
{
    public class TrEnrollmentResult
    {
        public int PeriodId { get; set; }

        public int EnrollId { get; set; }

        public int CourseId { get; set; }

        public int EmployeeId { get; set; }

        public virtual MsEmployee Participant { get; set; }

        public virtual MsCourse Course { get; set; }

        public virtual MsPeriod Period { get; set; }
    }
}
