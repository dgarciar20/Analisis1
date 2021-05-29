using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class tbl_detalleVenta
    {
        public int idDetalleVenta { get; set; }
        [Required]

        public int cantidad { get; set; }

        public decimal PrecioDetalleVenta { get; set; }

        public decimal descuento { get; set; }

    }
}