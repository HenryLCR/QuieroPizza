using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckyBurguer.BL
{                    //Herencia
    public class Contexto : DbContext
    {
        //constructor
        public Contexto(): base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\ChuckyBurguerDB.mdf")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Database.SetInitializer(new DatosdeInicio());
        }


        //propiedad
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Orden> Ordenes { get; internal set; }
        public DbSet<OrdenDetalle> OrdenDetalle { get; set; }
    }
}
