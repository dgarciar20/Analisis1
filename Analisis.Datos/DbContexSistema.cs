using Microsoft.EntityFrameworkCore;
using Analisis.Datos.Mapping.Almacen;
using Analisis.Datos.Mapping.Ventas;
using Analisis.Datos.Mapping.Usuarios;
using Analisis.Entidades.Almacen;
using Analisis.Entidades.Usuario;
using Analisis.Entidades.Ventas;
using Analisis.Entidades.Personas;

namespace Analisis.Datos
{
    public class DbContexSistema : DbContext
    {
        public DbSet<tbl_categoria> Categorias { get; set; }

        public DbSet<tbl_articulo> Articulos { get; set; }

        public DbSet<Persona> Persona { get; set; }

        public DbSet<tbl_Rol> Rols { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


        public DbSet<tbl_detalleingreso> detalle_ingresos { get; set; }

        public DbSet<tbl_detalleVenta> detalle_ventas { get; set; }

        public DbSet<tbl_ingreso> ingresos { get; set; }

        public DbSet<tbl_Venta> ventas { get; set; }
        public object Articuloss { get; set; }
        public object Personas { get; set; }
        public object Usuarioss { get; set; }

        public DbContexSistema(DbContextOptions<DbContexSistema> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_categoriaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_articuloMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_PersonaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_RolMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_detalleingresoMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_DetalleVentaMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_ingresoMap());

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new tbl_VentaMap());
        }



    }
}