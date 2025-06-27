using System.ComponentModel.DataAnnotations;

namespace LondonPerf.Models
{
    public class Perfume
    {
        private int id;
        private string marca;
        private string modelo;
        private decimal precio;
        private string gama;

        public Perfume(int id, string marca, string modelo, decimal precio, string gama)
        {
            this.Id = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Gama = gama;
        }

        public Perfume()
        {
            this.Id = 0;
            this.Marca = "";
            this.Modelo = "";
            this.Precio = 0;
            this.Gama = "";
        }

        [Key]
        public int Id { get => id; set => id = value; }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public string Gama { get => gama; set => gama = value; }



    }
}
