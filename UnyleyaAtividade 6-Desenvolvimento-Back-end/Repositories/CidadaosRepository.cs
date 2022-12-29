using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Context;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Model;

namespace UnyleyaAtividade_6_Desenvolvimento_Back_end.Repositories
{
    public class CidadaosRepository : ICidadaosRespository
    {
        public readonly CidadaosContext _context;
        public CidadaosRepository(CidadaosContext context)
        {
            _context = context;
        }

        public async Task<Cidadaos> Create(Cidadaos cidadao)
        {
            _context.Cidadaos.Add(cidadao);
            await _context.SaveChangesAsync();
            return cidadao;
        }

        public async Task Delete(int Id)
        {

            var cidadao = await _context.Cidadaos.FindAsync(Id);
            _context.Remove(cidadao);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cidadaos>> Get()
        {
            return await _context.Cidadaos.ToListAsync();
        }

        public async Task<Cidadaos> Get(int Id)
        {
            return await _context.Cidadaos.FindAsync(Id);
        }

        public async Task<List<Cidadaos>> GetByCPF(string cpf)
        {
            return await _context.Cidadaos.Where(x => x.Cpf.Contains(cpf)).ToListAsync();
        }

        public async Task<List<Cidadaos>> GetByName(string name)
        {
            return await _context.Cidadaos.Where(x => x.Nome.Contains(name)).ToListAsync();
        }

        public async Task Update(Cidadaos cidadao)
        {
            _context.Entry(cidadao).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
