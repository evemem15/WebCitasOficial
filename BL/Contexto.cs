using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Contexto : DbContext
    {
        public Contexto() : base("Clinica")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }



        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Hora> Horas { get; set; }
    }
}
