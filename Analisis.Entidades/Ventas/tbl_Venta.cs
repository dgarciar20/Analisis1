using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Analisis.Entidades.Ventas;


namespace Analisis.Entidades.Ventas
{
    public class tbl_Venta
    {
        public int idVenta { get; set; }
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
