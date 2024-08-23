using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapi_1.Models;

public partial class KamDbContext : DbContext
{
    public KamDbContext()
    {
    }

    public KamDbContext(DbContextOptions<KamDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Time> Times { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WINDOWS-72BBIO9\\SQLEXPRESS02;Database=KamDB;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Student");

            entity.Property(e => e.Ad)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("ad");
            entity.Property(e => e.Int)
                .ValueGeneratedOnAdd()
                .HasColumnName("int");
            entity.Property(e => e.Kart).HasColumnName("kart");
            entity.Property(e => e.Soyad)
                .HasMaxLength(40)
                .IsFixedLength()
                .HasColumnName("soyad");
        });

        modelBuilder.Entity<Time>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Time");

            entity.Property(e => e.Cixis).HasColumnName("cixis");
            entity.Property(e => e.Giris).HasColumnName("giris");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kart).HasColumnName("kart");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
