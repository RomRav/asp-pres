using monpetittuto.Models;
using Microsoft.EntityFrameworkCore;
namespace monpetittuto.Data
{
    public class DbConnect : DbContext
    {
        public DbConnect(DbContextOptions<DbConnect> option):base(option)
        {

        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ShopModel> Shop { get; set; }
    }
}
