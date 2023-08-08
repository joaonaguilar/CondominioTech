using JNA.Condominio.Domain.Models;
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
        //public IEnumerable<Morador> GetMoradores()
        //{
        //    return _context.Morador.ToList();
        //}

        [HttpPost]
        public IActionResult PostMorador(Morador morador)
        {
            _context.Morador.Add(morador);
            _context.SaveChanges();

            return Ok();
            //return CreatedAtAction(nameof(GetMoradores), new { id = morador.Id }, morador);
        }

        //[HttpPut("{id}")]
        //public IActionResult PutMorador(int id, Morador morador)
        //{
        //    if (id != morador.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(morador).State = EntityState.Modified;
        //    _context.SaveChanges();

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteMorador(int id)
        //{
        //    var morador = _context.Moradores.Find(id);
        //    if (morador == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Moradores.Remove(morador);
        //    _context.SaveChanges();

        //    return NoContent();
        //}
    }
}
