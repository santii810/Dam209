using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ADAT_UD4_EJ1.Model
{
    public class Context: DbContext
    {
        public Context()
            : base("AsistenciasTecnicas")
        { }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conexion> Conexiones { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Incidencia> Incidencias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
