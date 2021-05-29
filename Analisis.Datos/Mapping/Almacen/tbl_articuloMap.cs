using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Almacen;

namespace Analisis.Datos.Mapping.Almacen
{

    public class tbl_articuloMap : IEntityTypeConfiguration<tbl_articulo>
    {
        public void Configure(EntityTypeBuilder<tbl_articulo> builder)
        {
            builder.ToTable("Articulo")
                   .HasKey(c => c.idarticulo);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.codigo)
               .HasMaxLength(50);
            builder.Property(c => c.PrecioVenta)
            .HasMaxLength(50);
            builder.Property(c => c.stock)
            .HasMaxLength(50);
            builder.Property(c => c.descripcion)
            .HasMaxLength(256);
        }


    }
}