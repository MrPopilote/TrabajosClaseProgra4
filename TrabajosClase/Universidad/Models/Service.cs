using System.Data.Entity;

namespace Universidad.Models
{
    public class Service: DbContext
    {
        //Enlace de la aplicacion a la base de datos 
        public DbSet<Estudiante> estudiantes { get; set; } 
        public DbSet<Carrera> carreras { get; set; }

        //Nombre de la base de datos tiene que ser igual que el archivo de configuracion 
        public Service(): base("Universidad") { }

        public void agregarEstudiante(Estudiante estudiante) {
            
            estudiantes.Add(estudiante); //Agrega direcctamente a la DB
            SaveChanges(); // Y guarda los cambios de la DB osea el commit
        }

        public Array mostrarEstudiantes() { 
            return estudiantes.ToArray(); //Devuelve la lista de los estudiantes
        }


        //Metodos 
        public void agregarCarrera(Carrera carrera) {
            carreras.Add(carrera);
            SaveChanges();
        }

        public Array mostrarCarreras()
        {
            return carreras.ToArray();
        }






    }
}
