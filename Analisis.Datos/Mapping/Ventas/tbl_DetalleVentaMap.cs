using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Ventas;

namespace Analisis.Datos.Mapping.Ventas
{
    public class tbl_DetalleVentaMap : IEntityTypeConfiguration<tbl_detalleVenta>
    {
        public void Configure(EntityTypeBuilder<tbl_detalleVenta> builder)
        {
            builder.ToTable("detalle_venta")
                   .HasKey(c => c.idDetalleVenta);
            builder.Property(c => c.cantidad)
                .HasMaxLength(50);
            builder.Property(c => c.PrecioDetalleVenta)
               .HasMaxLength(50);
            builder.Property(c => c.descuento)
               .HasMaxLength(50);

        }


    }
}