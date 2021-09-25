using Microsoft.EntityFrameworkCore;
using HospiEnCasa_1.App.Dominio_1;


namespace HospiEnCasa_1.App.Persistencia_1
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial catalog = HospiEncasaData");
            }
        }
    }
}