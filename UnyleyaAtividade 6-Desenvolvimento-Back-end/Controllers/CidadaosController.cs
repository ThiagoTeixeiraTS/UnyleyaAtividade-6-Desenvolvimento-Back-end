using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Model;
using UnyleyaAtividade_6_Desenvolvimento_Back_end.Repositories;

namespace UnyleyaAtividade_6_Desenvolvimento_Back_end.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CidadaosController : ControllerBase
    {
        private readonly ICidadaosRespository _cidadaosRespository;


        public CidadaosController(ICidadaosRespository cidadaosRespository)
        {
            _cidadaosRespository = cidadaosRespository; 
        }

        

        [HttpGet]
        public async Task<IEnumerable<Cidadaos>> GetCidadaos()
        {
            return await _cidadaosRespository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cidadaos>> GetCidadaosById(int id)
        {
            return await _cidadaosRespository.Get(id);
        }

        [HttpGet("GetCidadaosByName/{name}")]
        public async Task<ActionResult<List<Cidadaos>>> GetCidadaosByName(string name)
        {
            return await _cidadaosRespository.GetByName(name);
        }


        [HttpGet("GetCidadaosByCPF/{cpf}")]
        public async Task<ActionResult<List<Cidadaos>>> GetCidadaosByAdress(string cpf)
        {
            return await _cidadaosRespository.GetByCPF(cpf);
        }

        [HttpPost]
        public async Task<ActionResult<Cidadaos>> PostCidadaos([FromBody] Cidadaos comp)
        {
            var newCompany = await _cidadaosRespository.Create(comp);
            return CreatedAtAction(nameof(GetCidadaos), new { id = newCompany.Id }, newCompany);
        }


        [HttpDelete("{Id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var comp = await _cidadaosRespository.Get(Id);
            if (comp == null)
                return NotFound();


            await _cidadaosRespository.Delete(comp.Id);
            return NoContent();


        }

        [HttpPut]
        public async Task<ActionResult> PutCidadaos(int id, [FromBody] Cidadaos comp)
        {
            if (id != comp.Id)
                return NotFound();


            await _cidadaosRespository.Update(comp);

            return Ok();
        }









    }
}
