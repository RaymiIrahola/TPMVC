using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Models
{
    public class Carta
    {
        public int CartaId { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public string Atributo { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
    }
}

