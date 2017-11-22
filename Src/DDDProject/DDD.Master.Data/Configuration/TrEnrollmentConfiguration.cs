using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class TrEnrollmentConfiguration
    {
        public TrEnrollmentConfiguration(EntityTypeBuilder<TrEnrollment> entity)
        {
            entity.ToTable("TrEnrollment");
            entity.HasKey(x => new { x.PeriodId, x.EnrollId });
            entity.Property(x => x.EnrollDesc).HasColumnType("varchar").IsRequired().HasMaxLength(50);
        }
    }
}
