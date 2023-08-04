using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VintageShop.Datos;
using VintageShop.Entidades;
using VintageShop.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VintageShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZapatoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ZapatoController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: api/<ZapatoController>
        [HttpGet]

        public async Task<List<Zapato>> Get()
        {
            return await _context.Zapatos.ToListAsync();
        }

        // GET api/<ZapatoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ZapatoController>
        [HttpPost]
        public async Task<Zapato> Post([FromBody] ZapatoCreateViewModels request )
        {
            var zapato = new Zapato
            {
                Name = request.Name,
                Price = request.Price,
                Talle = request.Talle,
            };

            await _context.AddAsync(zapato);
            await _context.SaveChangesAsync();

            return zapato;
        }

        // PUT api/<ZapatoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ZapatoController>/5
        [HttpDelete("{id}")]
        public async Task<Zapato> Delete(int id)
        {
            var zapato = await _context.Zapatos.FindAsync(id);

            if (zapato == null)
                throw new Exception("Id invalido");

            _context.Remove(zapato);
            await _context.SaveChangesAsync();
            return zapato;
        }
    }
}
