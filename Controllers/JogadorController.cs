using CBFWebApi.Entidades;
using CBFWebApi.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBFWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private static readonly JogadorService _jogadorService = new JogadorService();
        [HttpGet]
        public ActionResult All()
        {
            var response = _jogadorService.Jogadores();
            return (response != null) ?  Ok(response) : NotFound();
        }

        [HttpPost]
        public ActionResult Create(Jogador jogador)
        {
            if (_jogadorService.Create(jogador as Jogador))
            {
                return Ok("Jogador Criado com sucesso!");
            }

            return BadRequest("Não foi possivel adicionar este jogador");
        }
    }
}
