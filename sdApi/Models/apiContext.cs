using Microsoft.EntityFrameworkCore;

namespace sdApi.Models
{
    public class apiContext : DbContext
    {
        public apiContext(DbContextOptions<apiContext> options)
            : base(options)
        {
        }

        public DbSet<DadosViagem> DadosViagems { get; set; }
    }
}