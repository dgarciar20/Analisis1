using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Analisis.Datos;
using Analisis.Entidades.Usuario;
using Analisis.Entidades.Personas;

namespace Analisis.Web.Controllers
{


    [Route("api/[controller]")]
    [ApiController]


    public class PersonaController : ControllerBase
    {

        private readonly DbContexSistema _context;

        public PersonaController(DbContexSistema context)
        {
            _context = context;
        }

        //GET api/Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            return await _context.Personas.ToListAsync();
        }


        //GET api/Persona/2
        [HttpGet("{idPersona}")]

        public async Task<ActionResult<Persona>> GetPersona(int id)
        {
            var Persona = await _context.Personas.FindAsync(id);



            if (Persona == null)
            {
                return NotFound();
            }

            return Persona;
        }

        //Put api/Persona/2
        [HttpPut("idPersona")]
        public async Task<IActionResult> PutPersona(int id, Persona persona)
        {
            if (id != persona.idPersona)
            {
                return BadRequest();
            }

            //MI ENTIDAD YA TIENE LAS PROPIEDADDES O INFO QUE VOY A GUARDAR EN MY DB
            _context.Entry(persona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonaExists(id))
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

        //POst api/Persona
        [HttpPost]
        public async Task<ActionResult<Persona>> PostPersona(Persona persona)
        {
            _context.Personas.Add(persona);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersona", new { id = persona.idPersona }, persona);
        }

        //Delete api/Persona/2

        [HttpDelete("idPersona")]
        public async Task<ActionResult<Persona>> DeletePersona(int id)
        {
            var persona = await _context.Personas.FindAsync(id);

            if (persona == null)
            {
                return NotFound();
            }

            _context.Personas.Remove(persona);
            await _context.SaveChangesAsync();

            return persona;
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.idpersona == id);
        }









    }
}
