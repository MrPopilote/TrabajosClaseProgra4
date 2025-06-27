using System.Data.Entity;

namespace LondonPerf.Models
{
    public class Service: DbContext
    {
        public DbSet<Perfume> perfumes { get; set; }
        public Service(): base("LondonPerf") { }

        public void agregarPerfume(Perfume perfume)
        {
            perfumes.Add(perfume);
            SaveChanges();
        }

        public Array mostrarPerfumes()
        {
            return perfumes.ToArray();
        }

        public Perfume buscarPerfume(int id)
        {
            var perfumeBuscado = this.perfumes.FirstOrDefault(x => x.Id == id);
            if (perfumeBuscado != null)
                return perfumeBuscado;
            else throw new Exception("Ese perfume no esta registrado");

        }
        public void eliminarPerfume(Perfume perfume)
        {

            this.perfumes.Remove(perfume);
            SaveChanges();
        }

    }
}
