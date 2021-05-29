﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Entidades.Usuario
{
    public class tbl_Rol
    {

        public int idRol { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "El nombre debe de tener maximo de 30 caracteres, y no menos de 3 caracteres.")]

        public String nombre { get; set; }
        [StringLength(100, ErrorMessage = "La direccion  su tamaño maximo es de 100 caracteres.")]

        public String descripcion { get; set; }

        public bool condicion { get; set; }

    }
}