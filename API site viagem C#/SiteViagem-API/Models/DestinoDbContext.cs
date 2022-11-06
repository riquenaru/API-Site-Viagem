using Microsoft.EntityFrameworkCore;
using SiteViagem_API.Model;

namespace SiteViagem_API.Models
{
    public class DestinoDbContext : DbContext
    {

        public DestinoDbContext(DbContextOptions<DestinoDbContext> options)
            : base(options) { }

        public DbSet<Destino> Destinos { get; set; }
    }
}
