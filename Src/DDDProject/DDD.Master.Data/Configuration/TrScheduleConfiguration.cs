using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class TrScheduleConfiguration
    {
        public TrScheduleConfiguration(EntityTypeBuilder<TrSchedule> entity)
        {
            entity.ToTable("TrSchedule");
            entity.HasKey(x => new { x.PeriodId, x.ScheduleId });
        }
    }
}
