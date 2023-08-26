using JNA.Condominio.Domain.Model;
using JNA.Condominio.Infra.Data;
using Microsoft.AspNetCore.Mvc;

namespace JNA.Condominio.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoradorController : ControllerBase
    {
        private readonly db_CondominioContext _context;

        //[HttpGet]
        //public IEnumerable<Morador> Get()
        //{
        //    return _context.Morador.ToList();
        //}

        [HttpPost]
        public IActionResult Post(Morador morador)
        {
            return Ok();
        }
    }
}
