using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master
{
    public class TrEnrollment
    {
        public int PeriodId { get; set; }

        public int EnrollId { get; set; }

        public String EnrollDesc { get; set; }

        public DateTime EnrollStart { get; set; }

        public DateTime EnrollEnd { get; set; }
    }
}
