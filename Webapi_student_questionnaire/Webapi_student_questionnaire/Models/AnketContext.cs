using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Webapi_student_questionnaire.Models;

public partial class AnketContext : DbContext
{
    public AnketContext()
    {
    }

    public AnketContext(DbContextOptions<AnketContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<Response> Responses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WINDOWS-72BBIO9\\SQLEXPRESS02;Database=Anket;Trusted_Connection=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Question>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Question__0DC06F8C1253EC89");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.QuestionText).HasMaxLength(255);

            entity.HasOne(d => d.StudentNumberNavigation).WithMany(p => p.Questions)
                .HasPrincipalKey(p => p.StudentNumber)
                .HasForeignKey(d => d.StudentNumber)
                .HasConstraintName("FK__Questions__Stude__3D5E1FD2");
        });

        modelBuilder.Entity<Response>(entity =>
        {
            entity.HasKey(e => e.ResponseId).HasName("PK__Response__1AAA640C1798CF3B");

            entity.Property(e => e.ResponseId).HasColumnName("ResponseID");
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.Responses)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__Responses__Quest__403A8C7D");

            entity.HasOne(d => d.StudentNumberNavigation).WithMany(p => p.Responses)
                .HasPrincipalKey(p => p.StudentNumber)
                .HasForeignKey(d => d.StudentNumber)
                .HasConstraintName("FK__Responses__Stude__412EB0B6");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52A79EB06847D");

            entity.HasIndex(e => e.StudentNumber, "UQ__Students__DD81BF6CDD047B81").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.StudentNumber).IsRequired();
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserAcco__1788CCAC530329CD");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.RegistrationDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.StudentNumberNavigation).WithMany(p => p.UserAccounts)
                .HasPrincipalKey(p => p.StudentNumber)
                .HasForeignKey(d => d.StudentNumber)
                .HasConstraintName("FK__UserAccou__Stude__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
