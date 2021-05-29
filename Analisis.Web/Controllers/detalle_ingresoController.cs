using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Entidades.Ventas;
using Analisis.Datos;
namespace Analisis.Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class detalle_ingresoController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public detalle_ingresoController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/detalle_ingreso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_detalleingreso>>> Getdetalle_ingresos()
        {
            return await _context.detalle_ingresos.ToListAsync();
        }


        //GET api/detalle_ingreso/2
        [HttpGet("{idingreso}")]

        public async Task<ActionResult<tbl_detalleingreso>> Getdetalle_ingreso(int id)
        {
            var detalle_ingreso = await _context.detalle_ingresos.FindAsync(id);



            if (detalle_ingreso == null)
            {
                return NotFound();
            }

            return detalle_ingreso;
        }

        //Put api/detalle_ingreso/2
        [HttpPut("idingreso")]
        public async Task<IActionResult> PutCategoria(int id, tbl_detalleingreso detalle_ingreso)
        {
            if (id != detalle_ingreso.idingreso)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(detalle_ingreso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!detalle_ingresoExists(id))
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

        //POst api/detalle_ingreso
        [HttpPost]
        public async Task<ActionResult<tbl_detalleingreso>> Postdetalle_ingreso(tbl_detalleingreso detalle_ingreso)
        {
            _context.detalle_ingresos.Add(detalle_ingreso);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getdetalle_ingreso", new { id = detalle_ingreso.idingreso }, detalle_ingreso);
        }

        //Delete api/detalle_ingreso/2

        [HttpDelete("idingreso")]
        public async Task<ActionResult<tbl_detalleingreso>> Deletedetalle_ingreso(int id)
        {
            var detalle_ingreso = await _context.detalle_ingresos.FindAsync(id);

            if (detalle_ingreso == null)
            {
                return NotFound();
            }

            _context.detalle_ingresos.Remove(detalle_ingreso);
            await _context.SaveChangesAsync();

            return detalle_ingreso;
        }

        private bool detalle_ingresoExists(int id)
        {
            return _context.detalle_ingresos.Any(e => e.idingreso == id);
        }









    }
}
