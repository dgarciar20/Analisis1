using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Almacen;

namespace Analisis.Datos.Mapping.Almacen
{
    public class tbl_categoriaMap : IEntityTypeConfiguration<tbl_categoria>
    {
        public void Configure(EntityTypeBuilder<tbl_categoria> builder)
        {
            builder.ToTable("Categoria")
                   .HasKey(c => c.idcategoria);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.descripcion)
                .HasMaxLength(256);
        }


    }
}
