using System.ComponentModel.DataAnnotations;

namespace Tarea2Progra4_Condominio.Models
{
    public class Condominio
    {
        //Variables:
        private int idCondominio;
        private string nombreDuenno;
        private int identificador; //no se si es lo mismo o diferente del id
        private decimal precioDolares; //en decimal por ser dinero
        private bool estadoRemate; // si o no
        private float cantidadMetros; //no se ocupa tanto espacio en memoria como el decimal
        private bool tieneGaraje; //extra
        private bool tienePiscina; //extra
        private bool tieneJardin; //extra
        private string telefonoContacto;
        private string correo;
        private string provincia;
        private string direccionExacta;

        //Constructores:
        public Condominio(int idCondominio, string nombreDuenno, int identificador, decimal precioDolares, bool estadoRemate, float cantidadMetros, bool tieneGaraje, bool tienePiscina, bool tieneJardin, string telefonoContacto, string correo, string provincia, string direccionExacta)
        {
            this.IdCondominio = idCondominio;
            this.NombreDuenno = nombreDuenno;
            this.Identificador = identificador;
            this.PrecioDolares = precioDolares;
            this.EstadoRemate = estadoRemate;
            this.CantidadMetros = cantidadMetros;
            this.TieneGaraje = tieneGaraje;
            this.TienePiscina = tienePiscina;
            this.TieneJardin = tieneJardin;
            this.TelefonoContacto = telefonoContacto;
            this.Correo = correo;
            this.Provincia = provincia;
            this.DireccionExacta = direccionExacta;
        }

        public Condominio()
        {
            this.IdCondominio = 0;
            this.NombreDuenno = "";
            this.Identificador = 0;
            this.PrecioDolares = 0;
            this.EstadoRemate = false; //inicialmente no la posee el banco
            this.CantidadMetros = 0;
            this.TieneGaraje = false;
            this.TienePiscina = false;
            this.TieneJardin = false;
            this.TelefonoContacto = "";
            this.Correo = "";
            this.Provincia = "";
            this.DireccionExacta = "";
        }

        //Encapsuladores como propiedades:
        [Key]
        public int IdCondominio { get => idCondominio; set => idCondominio = value; }

        public string NombreDuenno { get => nombreDuenno; set => nombreDuenno = value; }
        public int Identificador { get => identificador; set => identificador = value; }
        public decimal PrecioDolares { get => precioDolares; set => precioDolares = value; }
        public bool EstadoRemate { get => estadoRemate; set => estadoRemate = value; }
        public float CantidadMetros { get => cantidadMetros; set => cantidadMetros = value; }
        public bool TieneGaraje { get => tieneGaraje; set => tieneGaraje = value; }
        public bool TienePiscina { get => tienePiscina; set => tienePiscina = value; }
        public bool TieneJardin { get => tieneJardin; set => tieneJardin = value; }
        public string TelefonoContacto { get => telefonoContacto; set => telefonoContacto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string DireccionExacta { get => direccionExacta; set => direccionExacta = value; }
    }
}
