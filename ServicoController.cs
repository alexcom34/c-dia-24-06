using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using servico.models; // Importe as suas entidades conforme necessário

namespace servico.Controllers
{
    [ApiController]
    [Route("api/servicos")]
    [Authorize] // Todos os endpoints deste controller requerem autenticação
    public class ServicoController : ControllerBase
    {
        // Injeção de dependências, se necessário

        [HttpGet]
        public IActionResult GetServicos()
        {
            // Lógica para obter todos os serviços
            return Ok("Lista de serviços");
        }

        [HttpPost]
        public IActionResult CriarServico(Servico servico)
        {
            // Lógica para criar um serviço
            return Ok("Serviço criado com sucesso");
        }

        [HttpGet("{id}")]
        public IActionResult GetServicoById(int id)
        {
            // Lógica para obter serviço por ID
            return Ok($"Detalhes do serviço com ID {id}");
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarServico(int id, Servico servico)
        {
            // Lógica para atualizar serviço
            return Ok($"Serviço com ID {id} atualizado com sucesso");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarServico(int id)
        {
            // Lógica para deletar serviço
            return Ok($"Serviço com ID {id} deletado com sucesso");
        }
    }
}
