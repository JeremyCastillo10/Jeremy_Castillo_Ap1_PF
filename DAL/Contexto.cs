using Microsoft.EntityFrameworkCore;
using Jeremy_Castillo_Ap1_PF.Entidades;

namespace Jeremy_Castillo_Ap1_PF.DAL
{
    public class Contexto : DbContext
    {
        
        public DbSet<Estudiantes> Estudiantes {get; set;}
        public DbSet<TiposDocumentos> TiposDocumentos {get; set;}

        public DbSet<Expedientes> Expedientes  {get; set;}

        public DbSet<Nacionalidades> Nacionalidades {get; set;}
        
        public Contexto(DbContextOptions<Contexto> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nacionalidades>().HasData(
                new Nacionalidades{NacionalidadId = 1, Descripcion = "Argentina"},
                new Nacionalidades{NacionalidadId = 2, Descripcion = "Bolivia"},
                new Nacionalidades{NacionalidadId = 3, Descripcion = "Colombia"},
                new Nacionalidades{NacionalidadId = 4, Descripcion = "Dominica"},
                new Nacionalidades{NacionalidadId = 5, Descripcion = "Ecuador"},
                new Nacionalidades{NacionalidadId = 6, Descripcion = "España"},
                new Nacionalidades{NacionalidadId = 7, Descripcion = "Haiti"},
                new Nacionalidades{NacionalidadId = 8, Descripcion = "Republica Dominicana"},
                new Nacionalidades{NacionalidadId = 9, Descripcion = "Rusia"},
                new Nacionalidades{NacionalidadId = 10, Descripcion = "Venezuela"}
            );
        }

    }
}