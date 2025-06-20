namespace Universidad.Models
{
    public class Carrera
    {

        private int id;
        private string facultad;
        private string nombreCarrera;
        private bool certificacion;
        private string sede;

       

        public Carrera(int id, string facultad, string nombreCarrera, bool certificacion, string sede)
        {
            this.Id = id;
            this.Facultad = facultad;
            this.NombreCarrera = nombreCarrera;
            this.Certificacion = certificacion;
            this.Sede = sede;
        }

        public Carrera()
        {
            this.Id = 0;
            this.Facultad = "";
            this.NombreCarrera = "";
            this.Certificacion = true;
            this.Sede = "";
        }

        public int Id { get => id; set => id = value; } //falto ponerle el required que asigna la primary key, tener cuidado a la proxima
        public string Facultad { get => facultad; set => facultad = value; }
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public bool Certificacion { get => certificacion; set => certificacion = value; }
        public string Sede { get => sede; set => sede = value; }
    }
}
