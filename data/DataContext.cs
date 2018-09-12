using Microsoft.EntityFrameworkCore;
using NavPark_API.Models;

namespace NavPark_API.data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Users> Users {get; set;}
        
    }
}