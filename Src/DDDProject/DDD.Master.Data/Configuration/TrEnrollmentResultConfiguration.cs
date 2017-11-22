using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class TrEnrollmentResultConfiguration
    {
        public TrEnrollmentResultConfiguration(EntityTypeBuilder<TrEnrollmentResult> entity)
        {
            entity.ToTable("TrEnrollmentResult");
            entity.HasKey(x => new { x.PeriodId, x.EnrollId, x.CourseId, x.EmployeeId });
            entity.Property(p => p.PeriodId).IsRequired();
            entity.Property(p => p.CourseId).IsRequired();
            entity.Property(p => p.EnrollId).IsRequired();
            entity.Property(p => p.EmployeeId).IsRequired();
        }
    }
}
