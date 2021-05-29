using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Usuario;

namespace Analisis.Datos.Mapping.Usuarios
{
    public class tbl_RolMap : IEntityTypeConfiguration<tbl_Rol>
    {
        public void Configure(EntityTypeBuilder<tbl_Rol> builder)
        {
            builder.ToTable("Rol")
                   .HasKey(c => c.idRol);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.descripcion)
               .HasMaxLength(50);


        }


    }
}