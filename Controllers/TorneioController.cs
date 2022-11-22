using CBFWebApi.Entidades;
using CBFWebApi.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBFWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TorneioController : ControllerBase
    {
        private static readonly TorneioService _torneioService = new TorneioService();

        [HttpGet]
        public ActionResult All()
        {
            var response = _torneioService.All();
            return response == null ? NotFound() : Ok(response);
        }

        [HttpPost]
        public ActionResult Create(Torneio torneio)
        {
            return _torneioService.Crate(torneio) ? Ok("Torneio criadom sucesso!") : BadRequest();
        }

        [HttpPost("{torneioId}/partidas/{partidaId}/eventos/inicio")]
        public ActionResult IniciarPartida(int torneioId, int partidaId, int inicio)
        {
            var torneio = _torneioService.GetById(torneioId);
            if (torneio == null)
            {
                return BadRequest("Torneio inexistente");
            }
            var partida = torneio.Partidas
                .Where(p => p.Id == partidaId)
                .FirstOrDefault();
            if (partida == null)
            {
                return BadRequest("Partida não pertence a este torneio!");
            }
            partida.Inicio = inicio;
            return Ok($"Partida iniciada aos {inicio} minutos");
        }

        [HttpPost("{torneioId}/partidas/{partidaId}/eventos/gol")]
        public ActionResult MarcarGol(int torneioId, int partidaId, int gol)
        {
            var torneio = _torneioService.GetById(torneioId);
            if (torneio == null)
            {
                return BadRequest("Torneio inexistente");
            }
            var partida = torneio.Partidas
                .Where(p => p.Id == partidaId)
                .FirstOrDefault();
            if (partida == null)
            {
                return BadRequest("Partida não pertence a este torneio!");
            }
            partida.Gols++;
            return Ok($"Goool!");
        }
    }
}
