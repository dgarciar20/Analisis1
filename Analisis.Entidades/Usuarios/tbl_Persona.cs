using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Analisis.Entidades.Usuarios;

namespace Analisis.Entidades.Personas
{
    public class Persona
    {
        public int idPersona { get; set; }
        [Required]

        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 30 caracteres, y no menos de 3 caracteres.")]

        public int tipoPersona { get; set; }

        public String nombre { get; set; }

        public String tipoDocumento { get; set; }

        public String numDocumento { get; set; }

        public String direccion { get; set; }

        public String telefono { get; set; }
        public String email { get; set; }


    }
}