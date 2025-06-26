using System.Data.Entity;

namespace Tarea2Progra4_Condominio.Models
{
    public class Service: DbContext
    {
        public DbSet<Condominio> condominios { get; set; }

        public Service(): base("CondominioDB") { }

        //CRUD:
        public void agregarCondominio(Condominio condominio)
        {
            condominios.Add(condominio);
            SaveChanges();
        }

        public Array mostrarCondominios(){
            return condominios.ToArray();
        }
    }
}
