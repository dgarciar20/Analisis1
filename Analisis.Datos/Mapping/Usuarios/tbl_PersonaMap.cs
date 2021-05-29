using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Analisis.Entidades.Usuarios;
using Analisis.Entidades.Personas;

namespace Analisis.Datos.Mapping.Usuarios
{

    public class tbl_PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona")
                   .HasKey(c => c.idPersona);
            builder.Property(c => c.tipoPersona)
                .HasMaxLength(50);

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

        }


    }
}