using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ApiUtsNet.Models;

namespace ApiUtsNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Pais
        [HttpGet]
        public ActionResult<IEnumerable<Pais>> GetPaises()
        {
            return _context.Paises.ToList();
        }

        // GET: api/Paises/1
        [HttpGet("{id}")]
        public ActionResult<Pais> GetPais(long id)
        {
            var pais = _context.Paises.Find(id);
            if (pais == null)
            {
                return NotFound();
            }
            return pais;
        }

        // POST: api/Pais
        [HttpPost]
        public ActionResult<Pais> CreatePais(Pais pais)
        {
            if (pais == null)
            {
                return BadRequest();
            }
            _context.Paises.Add(pais);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetPais), new { id = pais.Id }, pais);
        }
    }
}