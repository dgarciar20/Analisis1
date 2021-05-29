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


    public class CategoriasController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public CategoriasController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_categoria>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }


        //GET api/Categorias/2
        [HttpGet("{idcategoria}")]

        public async Task<ActionResult<tbl_categoria>> GetCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);



            if (categoria == null)
            {
                return NotFound();
            }

            return categoria;
        }

        //Put api/Categorias/2
        [HttpPut("idcategoria")]
        public async Task<IActionResult> PutCategoria(int id, tbl_categoria categoria)
        {
            if (id != categoria.idcategoria)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
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

        //POst api/Categorias
        [HttpPost]
        public async Task<ActionResult<tbl_categoria>> PostCategoria(tbl_categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = categoria.idcategoria }, categoria);
        }

        //Delete api/Categorias/2

        [HttpDelete("idcategoria")]
        public async Task<ActionResult<tbl_categoria>> DeleteCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return categoria;
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.idcategoria == id);
        }









    }
}