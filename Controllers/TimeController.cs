using CBFWebApi.Entidades;
using CBFWebApi.Servicos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CBFWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private static readonly TimeServices _timeServices = new TimeServices();

        [HttpGet]
        public ActionResult All()
        {
            var response = _timeServices.All();
            return response  == null ? BadRequest() :
            Ok(response);
        }

        [HttpPost]
        public ActionResult Create(Time time)
        {
            if (_timeServices.Create(time))
            {
                return Ok("Time Criado com sucesso!");
            }

            return BadRequest("Não foi possivel adicionar este time");
        }
    }
}
