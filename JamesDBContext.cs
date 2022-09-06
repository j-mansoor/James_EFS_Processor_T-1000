﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFS_FileProcessor
{
    public partial class JamesDBContext : DbContext
    {
        public JamesDBContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL2019-DEV;Initial Catalog=James;Integrated Security=True");
        }
        public JamesDBContext(DbContextOptions<JamesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Application> Application { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyApplication> PropertyApplication { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>(entity =>
            {
                entity.Property(e => e.Application1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Application");

                entity.Property(e => e.Assembly)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentationLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Namespace)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SingularName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCodeLocation)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.Property1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Property");
            });

            modelBuilder.Entity<PropertyApplication>(entity =>
            {
                entity.HasOne(d => d.Application)
                    .WithMany(p => p.PropertyApplication)
                    .HasForeignKey(d => d.ApplicationID)
                    .HasConstraintName("FK_PropertyApplication_Application");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyApplication)
                    .HasForeignKey(d => d.PropertyID)
                    .HasConstraintName("FK_PropertyApplication_Property");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}