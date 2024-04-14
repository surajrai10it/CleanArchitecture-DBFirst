using System;
using System.Collections.Generic;
using CleanArch.Infrastructure.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;

namespace CleanArch.Infrastructure.Data;

public partial class DbContextFist : DbContext
{
    public DbContextFist()
    {
    }

    public DbContextFist(DbContextOptions<DbContextFist> options)
        : base(options)
    {
    }

    public virtual DbSet<BuMaster> BuMasters { get; set; }

    public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }



    public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }



    public virtual DbSet<RoleMaster> RoleMasters { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .SetFileProvider(new PhysicalFileProvider(AppContext.BaseDirectory))
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BuMaster>(entity =>
        {
            entity.HasKey(e => e.BuId);

            entity.ToTable("BU_Master");

            entity.Property(e => e.BuId).HasColumnName("BU_Id");
            entity.Property(e => e.BuName)
                .HasMaxLength(15)
                .HasColumnName("BU_Name");
        });


        modelBuilder.Entity<DesignationMaster>(entity =>
        {
            entity.HasKey(e => e.DesignationId);

            entity.ToTable("Designation_Master");

            entity.Property(e => e.DesignationId).HasColumnName("Designation_Id");
            entity.Property(e => e.DesignationName)
                .HasMaxLength(150)
                .HasColumnName("Designation_Name");
        });

       
        modelBuilder.Entity<RoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.ToTable("Role_master");

            entity.Property(e => e.RoleId).HasColumnName("Role_Id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("Role_Name");
        });


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
