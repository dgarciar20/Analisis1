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


    public class detalle_ventaController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public detalle_ventaController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/detalle_venta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_detalleVenta>>> Getdetalle_venta()
        {
            return await _context.detalle_ventas.ToListAsync();
        }


        //GET api/detalle_venta/2
        [HttpGet("{idDetalleVenta}")]

        public async Task<ActionResult<tbl_detalleVenta>> Getdetalle_venta(int id)
        {
            var detalle_venta = await _context.detalle_ventas.FindAsync(id);



            if (detalle_venta == null)
            {
                return NotFound();
            }

            return detalle_venta;
        }

        //Put api/detalle_venta/2
        [HttpPut("idDetalleVenta")]
        public async Task<IActionResult> PutCategoria(int id, tbl_detalleVenta detalle_venta)
        {
            if (id != detalle_venta.idDetalleVenta)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(detalle_venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalle_ventaExists(id))
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

        //POst api/detalle_venta
        [HttpPost]
        public async Task<ActionResult<tbl_detalleVenta>> PostCategoria(tbl_detalleVenta detalle_venta)
        {
            _context.detalle_ventas.Add(detalle_venta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getdetalle_venta", new { id = detalle_venta.idDetalleVenta }, detalle_venta);
        }

        //Delete api/detalle_venta/2

        [HttpDelete("idDetalleVenta")]
        public async Task<ActionResult<tbl_detalleVenta>> Deletedetalle_venta(int id)
        {
            var detalle_venta = await _context.detalle_ventas.FindAsync(id);

            if (detalle_venta == null)
            {
                return NotFound();
            }

            _context.detalle_ventas.Remove(detalle_venta);
            await _context.SaveChangesAsync();

            return detalle_venta;
        }

        private bool detalle_ventaExists(int id)
        {
            return _context.detalle_ventas.Any(e => e.idDetalleVenta == id);
        }









    }
}