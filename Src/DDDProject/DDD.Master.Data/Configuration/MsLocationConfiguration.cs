using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class MsLocationConfiguration
    {
        public MsLocationConfiguration(EntityTypeBuilder<MsLocation> entity)
        {
            entity.ToTable("MsLocation");
            entity.HasKey(x => x.LocationId);
            entity.Property(x => x.LocationId).IsRequired();
            entity.Property(x => x.LocationDesc).IsRequired().HasColumnType("varchar").HasMaxLength(100);
        }
    }
}
