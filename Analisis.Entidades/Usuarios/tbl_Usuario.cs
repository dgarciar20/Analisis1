using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Entidades.Usuario
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 30 caracteres, y no menos de 3 caracteres.")]

        public String nombre { get; set; }
        [StringLength(10, ErrorMessage = "La direccion  su tamaño maximo es de 100 caracteres.")]

        public String tipoDocumento { get; set; }

        public String numDocumento { get; set; }

        public String direccion { get; set; }

        public String telefono { get; set; }

        public String email { get; set; }

        public String password_hash { get; set; }

        public String password_sat { get; set; }

        public bool condicion { get; set; }

    }
}