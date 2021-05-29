using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Analisis.Datos;
using Analisis.Entidades.Ventas;

namespace Analisis.Web.Controllers
{



    [Route("api/[controller]")]
    [ApiController]


    public class ventaController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public ventaController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Venta>>> Getventa()
        {
            return await _context.ventas.ToListAsync();
        }


        //GET api/venta/2
        [HttpGet("{idVenta}")]

        public async Task<ActionResult<tbl_Venta>> Getventa(int id)
        {
            var venta = await _context.ventas.FindAsync(id);



            if (venta == null)
            {
                return NotFound();
            }

            return venta;
        }

        //Put api/venta/2
        [HttpPut("idVenta")]
        public async Task<IActionResult> Putventa(int id, tbl_Venta venta)
        {
            if (id != venta.idVenta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ventaExists(id))
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

        //POst api/venta
        [HttpPost]
        public async Task<ActionResult<tbl_Venta>> Postventa(tbl_Venta venta)
        {
            _context.ventas.Add(venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getventa", new { id = venta.idVenta }, venta);
        }

        //Delete api/venta/2

        [HttpDelete("idVenta")]
        public async Task<ActionResult<tbl_Venta>> Deleteventa(int id)
        {
            var venta = await _context.ventas.FindAsync(id);

            if (venta == null)
            {
                return NotFound();
            }

            _context.ventas.Remove(venta);
            await _context.SaveChangesAsync();

            return venta;
        }

        private bool ventaExists(int id)
        {
            return _context.ventas.Any(e => e.idVenta == id);
        }









    }
}