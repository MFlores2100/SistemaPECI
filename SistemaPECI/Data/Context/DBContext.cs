using Microsoft.EntityFrameworkCore;
using SistemaPECI.Data.Entidades;


namespace SistemaPECI.Data.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Proyecto> Proyecto { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<ProyectoRegion> ProyectoRegion { get; set; }
        public DbSet<RegistroAuditoria> RegistroAuditoria { get; set; }
        public DbSet<ProyectoUsuario> ProyectoUsuario { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<MaterialEquipo> MaterialEquipo { get; set; }
        public DbSet<MaterialRequerido> MaterialRequerido { get; set; }
        public DbSet<ListaPrecios> ListaPrecios { get; set; }
        public DbSet<GestionFinanciamiento> GestionFinanciamiento { get; set; }
        public DbSet<DetalleRegion> DetalleRegion { get; set; }
        public DbSet<DetalleAuditoria> DetalleAuditoria { get; set; }
        public DbSet<ComposicionInversion> ComposicionInversion { get; set; }
        public DbSet<Canton> Canton { get; set; }
    }
}
