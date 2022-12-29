using System.Collections.Generic;
using System.Threading.Tasks;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Model;

namespace UnyleyaAtividade_6_Desenvolvimento_Back_end.Repositories
{

    public interface ICidadaosRespository
    {
        Task<IEnumerable<Cidadaos>> Get();

        Task<Cidadaos> Get(int Id);

        Task<Cidadaos> Create(Cidadaos companies);
        Task Update(Cidadaos companies);

        Task Delete(int Id);

        Task<List<Cidadaos>> GetByName(string name);
        Task<List<Cidadaos>> GetByCPF(string cpf);

    }
}
