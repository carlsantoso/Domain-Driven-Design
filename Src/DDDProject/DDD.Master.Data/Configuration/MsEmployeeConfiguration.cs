using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class MsEmployeeConfiguration
    {
        public MsEmployeeConfiguration(EntityTypeBuilder<MsEmployee> entity)
        {
            entity.ToTable("MsEmployee");
            entity.HasKey(x => x.EmployeeId);
            entity.Property(x => x.EmployeeId).IsRequired();
            entity.Property(x => x.EmployeeName).IsRequired().HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
