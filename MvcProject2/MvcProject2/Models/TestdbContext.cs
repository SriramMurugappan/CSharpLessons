using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MvcProject2.Models;

public partial class TestdbContext : DbContext
{
    public TestdbContext()
    {
    }

    public TestdbContext(DbContextOptions<TestdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmptblSriram> EmptblSrirams { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=200411LTP2748\\SQLEXPRESS;database=testdb;integrated security=true;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmptblSriram>(entity =>
        {
            entity.HasKey(e => e.Eno).HasName("PK_emptb");

            entity.ToTable("emptbl_Sriram");

            entity.Property(e => e.Eno)
                .ValueGeneratedNever()
                .HasColumnName("eno");
            entity.Property(e => e.City)
                .HasMaxLength(20)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Salary)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC079522D2AC");

            entity.ToTable("Movie");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Director)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HeroName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("heroName");
            entity.Property(e => e.Language)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MusicDirector)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.Review).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
