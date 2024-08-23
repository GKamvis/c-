using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi3.Model;

public partial class BankDbContext : DbContext
{
    public BankDbContext()
    {
    }

    public BankDbContext(DbContextOptions<BankDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medaxil> Medaxils { get; set; }

    public virtual DbSet<Mexaric> Mexarics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WINDOWS-72BBIO9\\SQLEXPRESS02;Database=bankDB;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medaxil>(entity =>
        {
            entity.ToTable("Medaxil");

            entity.Property(e => e.Aciqlama)
                .HasMaxLength(50)
                .HasColumnName("aciqlama");
            entity.Property(e => e.Miqdar).HasColumnName("miqdar");
            entity.Property(e => e.Tarix).HasColumnType("datetime");
        });

        modelBuilder.Entity<Mexaric>(entity =>
        {
            entity.ToTable("Mexaric");

            entity.Property(e => e.Aciqlama)
                .HasMaxLength(50)
                .HasColumnName("aciqlama");
            entity.Property(e => e.Miqdar).HasColumnName("miqdar");
            entity.Property(e => e.Tarix).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
