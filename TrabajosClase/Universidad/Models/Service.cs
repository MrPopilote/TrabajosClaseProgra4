using System.Data.Entity;

namespace Universidad.Models
{
    public class Service: DbContext
    {
        //Enlace de la aplicacion a la base de datos 
        public DbSet<Estudiante> estudiantes { get; set; } 

        //Nombre de la base de datos tiene que ser igual que el archivo de configuracion 
        public Service(): base("Universidad") { }
    }
}
