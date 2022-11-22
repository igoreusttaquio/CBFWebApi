using CBFWebApi.Entidades;
using CBFWebApi.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBFWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        private static readonly TransferenciaService _transferenciaService = new();

        [HttpGet]
        public ActionResult All()
        {
            var response = _transferenciaService.All();
            return response != null ? Ok(response) : NotFound();
        }

        [HttpPost]
        public ActionResult Create(Transferencia transferencia)
        {
            return _transferenciaService.Create(transferencia) ? Ok("Tranferencia com sucesso!") : BadRequest();
        }
    }
}
