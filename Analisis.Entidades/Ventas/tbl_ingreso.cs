using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class tbl_ingreso
    {
        public int idingreso { get; set; }
        [Required]

        public String tipoComprobante { get; set; }

        public String serieComprobante { get; set; }

        public String numComprobante { get; set; }

        public DateTime fechaHora { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }
        public int estado { get; set; }

    }
}
