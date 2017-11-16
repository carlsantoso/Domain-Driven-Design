using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Master.Data
{
    public class DDDContext : DbContext
    {
        public DDDContext(DbContextOptions<DDDContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<MsCourse> Courses { get; set; }
        public DbSet<MsEmployee> Employees { get; set; }
        public DbSet<MsLocation> Locations { get; set; }
        public DbSet<MsPeriod> Periods { get; set; }
        public DbSet<TrEnrollment> Enrollments { get; set; }
        public DbSet<TrEnrollmentCourse> EnrollmentCourses { get; set; }
        public DbSet<TrEnrollmentResult> EnrollmentResults { get; set; }
        public DbSet<TrSchedule> Schedules { get; set; }
        public DbSet<TrScheduleResult> ScheduleResults { get; set; }
        public DbSet<TrScheduleResultDetail> ScheduleResultDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Entity<MsCourse>().ToTable("MsCourse");
                modelBuilder.Entity<MsEmployee>().ToTable("MsEmployee");
                modelBuilder.Entity<MsLocation>().ToTable("MsLocation");
                modelBuilder.Entity<MsPeriod>().ToTable("MsPeriod");
                modelBuilder.Entity<TrEnrollment>().ToTable("TrEnrollment");
                modelBuilder.Entity<TrEnrollmentCourse>().ToTable("TrEnrollmentCourse");
                modelBuilder.Entity<TrEnrollmentResult>().ToTable("TrEnrollmentResult");
                modelBuilder.Entity<TrSchedule>().ToTable("TrSchedule");
                modelBuilder.Entity<TrScheduleResult>().ToTable("TrScheduleResult");
                modelBuilder.Entity<TrScheduleResultDetail>().ToTable("TrScheduleResultDetail");
            }
        }
    }
}
