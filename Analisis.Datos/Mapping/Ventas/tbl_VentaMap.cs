using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Ventas;

namespace Analisis.Datos.Mapping.Ventas
{
    public class tbl_VentaMap : IEntityTypeConfiguration<tbl_Venta>
    {
        public void Configure(EntityTypeBuilder<tbl_Venta> builder)
        {
            builder.ToTable("venta")
                   .HasKey(c => c.idVenta);
            builder.Property(c => c.tipoComprobante)
                .HasMaxLength(50);
            builder.Property(c => c.serieComprobante)
               .HasMaxLength(50);
            builder.Property(c => c.numComprobante)
               .HasMaxLength(50);
            builder.Property(c => c.fechaHora)
              .HasMaxLength(50);
            builder.Property(c => c.impuesto)
              .HasMaxLength(50);
            builder.Property(c => c.total)
              .HasMaxLength(50);
            builder.Property(c => c.estado)
             .HasMaxLength(50);

        }


    }
}