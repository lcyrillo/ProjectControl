using Microsoft.EntityFrameworkCore;
using ProjectControl.Models;

namespace ProjectControl.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) { }

        public virtual DbSet<Profile> Profile { get; set; }
    }
}