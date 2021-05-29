using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Datos;
using Analisis.Entidades.Usuario;

namespace Analisis.Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class RolController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public RolController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/Rol
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tbl_Rol>>> GetRols()
        {
            return await _context.Rols.ToListAsync();
        }


        //GET api/Rol/2
        [HttpGet("{idRol}")]

        public async Task<ActionResult<tbl_Rol>> GetRol(int id)
        {
            var rol = await _context.Rols.FindAsync(id);



            if (rol == null)
            {
                return NotFound();
            }

            return rol;
        }

        //Put api/Rol/2
        [HttpPut("idRol")]
        public async Task<IActionResult> PutRol(int id, tbl_Rol rol)
        {
            if (id != rol.idRol)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(rol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RolExists(id))
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

        //POst api/Rol
        [HttpPost]
        public async Task<ActionResult<tbl_Rol>> PostRol(tbl_Rol rol)
        {
            _context.Rols.Add(rol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRol", new { id = rol.idRol }, rol);
        }

        //Delete api/Rol/2

        [HttpDelete("idRol")]
        public async Task<ActionResult<tbl_Rol>> DeleteRol(int id)
        {
            var rol = await _context.Rols.FindAsync(id);

            if (rol == null)
            {
                return NotFound();
            }

            _context.Rols.Remove(rol);
            await _context.SaveChangesAsync();

            return rol;
        }

        private bool RolExists(int id)
        {
            return _context.Rols.Any(e => e.idRol == id);
        }









    }
}