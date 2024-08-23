


using System;
using Microsoft.EntityFrameworkCore;

namespace car_operations.Models;

public partial class CarsContext : DbContext
{
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Operation> Operations { get; set; }

    public CarsContext(DbContextOptions<CarsContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Burada sizin SQL server məlumatlarınızı qeyd etməlisiniz.
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=WINDOWS-72BBIO9\\SQLEXPRESS02;Initial Catalog=Cars;Integrated Security=True;Trust Server Certificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Number).IsRequired();
            entity.Property(e => e.Type).IsRequired();
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.OperationType).IsRequired();
            entity.Property(e => e.Car_id).IsRequired();
            entity.Property(e => e.Item).IsRequired();
            entity.Property(e => e.Amount).IsRequired();
            entity.Property(e => e.OperationDate).IsRequired();

            entity.HasOne<Car>()
                .WithMany()
                .HasForeignKey(d => d.Car_id)
                .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

public class Car
{
    public int Id { get; set; }
    public string Number { get; set; }
    public string Type { get; set; }
}

public class Operation
{
    public int Id { get; set; }
    public int OperationType { get; set; }
    public int Car_id { get; set; }
    public string Item { get; set; }
    public float Amount { get; set; }
    public DateTime OperationDate { get; set; }
}
