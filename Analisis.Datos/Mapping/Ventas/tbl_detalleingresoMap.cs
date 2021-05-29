using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Ventas;

namespace Analisis.Datos.Mapping.Ventas
{
    public class tbl_detalleingresoMap : IEntityTypeConfiguration<tbl_detalleingreso>
    {
        public void Configure(EntityTypeBuilder<tbl_detalleingreso> builder)
        {
            builder.ToTable("detalle_ingreso")
                   .HasKey(c => c.idingreso);
            builder.Property(c => c.tipoComprobante)
                .HasMaxLength(50);
            builder.Property(c => c.serieComprobante)
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