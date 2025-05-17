using Microsoft.EntityFrameworkCore;
using ShoppingApi_Jueves_2025I.DAL.Entities;

namespace ShoppingApi_Jueves_2025I.DAL
{
    public class DataBaseContext : DbContext
    {
        //asi me conecto a la base de datos por medio de este constructor
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {
            
        }

        //Este metodo es propio de EF CORE que sirve para configurar unos indices de cada campo de una tabla de BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); //Asi creo un indice del campo Name para la tabla Countries
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }

        #endregion
    }
}
