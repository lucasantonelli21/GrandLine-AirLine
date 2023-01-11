using Microsoft.EntityFrameworkCore;
using ControladorAviao.Models;
namespace ControladorAviao.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<VooModel>Voos { get; set; }
        public DbSet<AviaoModel> Avioes { get; set; }
    }
}
