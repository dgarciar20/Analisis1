using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Analisis.Datos;
using Analisis.Entidades.Almacen;


namespace Analisis.Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class ArticulosController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public ArticulosController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/Articulos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_articulo>>> GetArticulos()
        {
            return await _context.Articuloss.ToListAsync();

        }


        //GET api/Articulos/2
        [HttpGet("{idaritulo}")]

        public async Task<ActionResult<tbl_articulo>> GetArticulos(int id)
        {
            var Articulos = await _context.Articuloss.FindAsync(id);



            if (Articulos == null)
            {
                return NotFound();
            }

            return Articulos;
        }

        //Put api/Articulos/2
        [HttpPut("idarticulos")]
        public async Task<IActionResult> PutArticulos(int id, tbl_articulo Articulos)
        {
            if (id != Articulos.idarticulo)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(Articulos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticulosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        //POst api/Articulos
        [HttpPost]
        public async Task<ActionResult<tbl_articulo>> PostCategoria(tbl_articulo articulos)
        {
            _context.Articuloss.Add(articulos);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticulos", new { id = articulos.idarticulo }, articulos);
        }

        //Delete api/Articulos/2

        [HttpDelete("idarticulo")]
        public async Task<ActionResult<tbl_articulo>> DeleteArticulos(int id)
        {
            var Articulos = await _context.Articuloss.FindAsync(id);

            if (Articulos == null)
            {
                return NotFound();
            }

            _context.Articuloss.Remove(Articulos);
            await _context.SaveChangesAsync();

            return Articulos;
        }

        private bool ArticulosExists(int id)
        {
            return _context.Articuloss.Any(e => e.idarticulo == id);
        }









    }

}