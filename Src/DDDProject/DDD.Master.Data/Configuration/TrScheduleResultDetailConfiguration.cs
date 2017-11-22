using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class TrScheduleResultDetailConfiguration
    {
        public TrScheduleResultDetailConfiguration(EntityTypeBuilder<TrScheduleResultDetail> entity)
        {
            entity.ToTable("TrScheduleResultDetail");
            entity.HasKey(x => new { x.PeriodId, x.ScheduleId, x.EmployeeId });
        }
    }
}
