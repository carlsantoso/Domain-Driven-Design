using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class MsCourseConfiguration
    {
        public MsCourseConfiguration(EntityTypeBuilder<MsCourse> entity)
        {
            entity.ToTable("MsCourse");
            entity.HasKey(p => p.CourseId);
            entity.Property(p => p.CourseId).IsRequired();
            entity.Property(p => p.CourseName).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            entity.Property(p => p.CourseLevel).IsRequired();
        }
    }
}
