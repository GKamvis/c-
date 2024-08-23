using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi_2.Models;

namespace webapi_2.Data
{
    public class webapi_2Context : DbContext
    {
        public webapi_2Context (DbContextOptions<webapi_2Context> options)
            : base(options)
        {
        }
        public DbSet<webapi_2.Models.Student> Student { get; set; } = default!;
    }
}
