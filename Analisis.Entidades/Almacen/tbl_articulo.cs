using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class tbl_articulo
    {

        public int idarticulo { get; set; }
        [Required]
    
        public String codigo { get; set; }

        public String nombre { get; set; }

        public decimal PrecioVenta { get; set; }

        public float stock { get; set; }

        public String descripcion { get; set; }

        public int condicion { get; set; }

    }
}