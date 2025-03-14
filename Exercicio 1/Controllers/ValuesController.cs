using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exercicio_1.models;
using Exercicio_1.Data;
using System.Linq.Expressions;

namespace Exercicio_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
       // private static List<Cidade> Lista = new List<Cidade>();
        private readonly AppDbContext _Context;

        public ValuesController(AppDbContext context)
        {
            _Context = context;
        }
        // [HttpGet]
        //[Route("Lista")]
        // public List<Cidade> CidadeLista()
        // {

        //  return Lista;
        // }

        [HttpGet]
        public List<Cidade> GetCidade()
        {
            var lista = _Context.Cidades.OrderBy(c => c.nome).ToList();
            return lista;
        }

        [HttpPost]

        public IActionResult PostCidade([FromBody] Cidade cidade)
        {
            try
            {
                _Context.Cidades.Add(cidade);
                _Context.SaveChanges();
                return Ok("Cidade cadastrada com sucesso");
            }
            catch (Exception ex) {
                return BadRequest("erro ao incluir a ciade. " + ex.Message);
            }
        }

        [HttpPut]

        public IActionResult PutCidade([FromBody] Cidade cidade)
        {
            var cidadeExiste = _Context.Cidades
                               .Where(l => l.codigo == cidade.codigo)
                               .FirstOrDefault();
            if (cidadeExiste != null)
            {
                try
                {
                    cidadeExiste.nome = cidade.nome;
                    _Context.Cidades.Update(cidadeExiste);
                    _Context.SaveChanges();
                    return Ok ("Cidade alterada com sucesso");
                }
                catch (Exception ex)
                {
                    return BadRequest("erro ao alterar cidade. " + ex.Message);
                }
            }
            else
            {
                return NotFound ("Cidade nao encontrada");
            }
        }

        [HttpDelete("{codigo}")]

        public IActionResult DeleteCidade([FromRoute] int codigo)
        {
            var cidadeExiste = _Context.Cidades
                               .Where(l => l.codigo == codigo)
                               .FirstOrDefault();
            if (cidadeExiste != null)
            {
                try
                {
                    _Context.Cidades.Remove(cidadeExiste);
                    _Context.SaveChanges();
                    return Ok("Cidade excluida com sucesso");
                }
                catch (Exception ex)
                {
                    return BadRequest("Erro ao excluir cidade. " + ex.Message);
                }
            }
            else
            {
                return NotFound("Cidade não encontrado!");
            }
        }
    }
}
