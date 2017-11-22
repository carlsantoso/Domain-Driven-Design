using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class TrEnrollmentCourseConfiguration
    {
        public TrEnrollmentCourseConfiguration(EntityTypeBuilder<TrEnrollmentCourse> entity)
        {
            entity.ToTable("TrEnrollmentCourse");
            entity.HasKey(x => new { x.PeriodId, x.EnrollId, x.CourseId });
        }
    }
}
