using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Analisis.Entidades.Ventas;

namespace Analisis.Entidades.Ventas
{
    public class tbl_detalleingreso
    {
        public int idingreso { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "La direccion su tamaño maximo es de 100 caracteres.")]

        public string tipoComprobante { get; set; }

        public string serieComprobante { get; set; }

        public System.DateTime fechaHora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int estado { get; set; }
    }
}
