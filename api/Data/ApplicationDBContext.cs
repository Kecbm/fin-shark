using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            Stock = Set<StockModel>();
            Comments = Set<CommentModel>();
        }

        public DbSet<StockModel> Stock { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}