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

        //public ICollection<TrScheduleResultDetail> ScheduleResultDetails { get; set; }

        public virtual MsEmployee Trainer { get; set; }

        public virtual MsLocation Location { get; set; }

        public virtual MsCourse Course { get; set; }

        public virtual MsPeriod Periode { get; set; }

        private IList<TrScheduleResultDetail> _scheduleResultDetail;
        public IEnumerable<TrScheduleResultDetail> ScheduleResultDetails
        {
            get
            {
                return _scheduleResultDetail;
            }
        }

        public void AddScheduleResultDetail(TrScheduleResultDetail scheduleResultDetail)
        {
            //Do something if needed
            this._scheduleResultDetail.Add(scheduleResultDetail);
            //event to raise if any?
        }
    }
}
