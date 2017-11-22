using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class MsPeriodConfiguration
    {
        public MsPeriodConfiguration(EntityTypeBuilder<MsPeriod> entity)
        {
            entity.ToTable("MsPeriod");
            entity.HasKey(x => x.PeriodId);
            entity.Property(x => x.PeriodId).IsRequired();
            entity.Property(x => x.PeriodYear).IsRequired();
            entity.Property(x => x.PeriodQuarter).IsRequired();
            entity.Property(x => x.PeriodDesc).IsRequired().HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
