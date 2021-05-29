using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Analisis.Entidades.Usuario;

namespace Analisis.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios")
                   .HasKey(c => c.idUsuario);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            builder.Property(c => c.tipoDocumento)
                .HasMaxLength(50);
            builder.Property(c => c.numDocumento)
                .HasMaxLength(50);
            builder.Property(c => c.direccion)
                .HasMaxLength(50);
            builder.Property(c => c.telefono)
               .HasMaxLength(50);
            builder.Property(c => c.email)
               .HasMaxLength(50);
            builder.Property(c => c.password_hash)
               .HasMaxLength(50);
            builder.Property(c => c.password_sat)
               .HasMaxLength(50);

        }


    }
}
