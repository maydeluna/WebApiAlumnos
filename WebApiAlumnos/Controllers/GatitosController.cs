using Microsoft.AspNetCore.Mvc;
using WebApiAlumnos.BD;

namespace WebApiAlumnos.Controllers
{
    [ApiController]
    [Route("api/gatitos")]
    public class GatitosController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Gatito>> Get()
        {
            return new List<Gatito>()
            {

                new Gatito() { Id = 1, Nombre = "Benito"},
                new Gatito() { Id = 2, Nombre = "Biri"}
            };
        }

    }
}
