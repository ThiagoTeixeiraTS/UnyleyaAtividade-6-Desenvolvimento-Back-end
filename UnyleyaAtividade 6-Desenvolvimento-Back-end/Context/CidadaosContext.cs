using Microsoft.EntityFrameworkCore;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Model;

namespace UnyleyaAtividade_6_Desenvolvimento_Back_end.Context
{
    public class CidadaosContext:  DbContext
    {
        public CidadaosContext(DbContextOptions<CidadaosContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Cidadaos> Cidadaos { get; set; }
    }
}
