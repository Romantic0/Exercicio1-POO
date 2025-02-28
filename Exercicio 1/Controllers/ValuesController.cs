using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Exercicio_1.models;

namespace Exercicio_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Cidade> Lista = new List<Cidade>();

        [HttpGet]
        [Route("Lista")]
        public List<Cidade> CidadeLista()
        {
            return Lista;
        }

        [HttpPost]

        public string PostCidade(Cidade cidade)
        {
            Lista.Add(cidade);
            return "Cidade cadastrada com sucesso";
        }

        [HttpPut]

        public string PutCidade(Cidade cidade)
        {
            var cidadeExiste = Lista
                               .Where(l => l.codigo == cidade.codigo)
                               .FirstOrDefault();
            if (cidadeExiste != null)
            {
                cidadeExiste.nome = cidade.nome;
                return "Cidade alterada com sucesso";
            }
            else
            {
                return "Cidade nao encontrada";
            }
        }

        [HttpDelete]

        public string DeleteCidade(Cidade cidade)
        {
            var cidadeExiste = Lista
                               .Where(l => l.codigo == cidade.codigo)
                               .FirstOrDefault();
            if (cidadeExiste != null)
            {
                Lista.Remove(cidadeExiste);
                return "Cidade excluida com sucesso";
            }
            else
            {
                return "Cidade nao encontrada";
            }
        }
    }
}
