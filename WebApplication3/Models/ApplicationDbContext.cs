using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("DefaultConnection")
    {
    }

    // DbSet obyektləri ilə model cədvəllərini təmsil edin
    public DbSet<MyModel> MyModels { get; set; }
}

public class MyModel
{
    public int Id { get; set; }
    public string city { get; set; }
    public string adress { get; set; }
    public string time { get; set; }
    public string mesage { get; set; }
}
