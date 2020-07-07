using Microsoft.EntityFrameworkCore;
using Cadimm.Models;

namespace Cadimm.Data
{
    public class CadimmContext : DbContext
    {
        public CadimmContext (DbContextOptions<CadimmContext> options)
            : base(options)
        {
        }

        public DbSet<Membro> Membro { get; set; }
    }
}
