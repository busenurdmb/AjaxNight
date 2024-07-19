using AjaxNight.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AjaxNight.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-493DFJA\\SQLEXPRESS; initial catalog=AjaxNightDb;integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
