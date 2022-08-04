using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Models
{
    public class Repositorio
    {
        private static List<Carta> cartas = new List<Carta>();
        public static IEnumerable<Carta> Cartas => cartas;
        public static void AgregarCartaNueva(Carta carta) => cartas.Add(carta);
    
        public static IEnumerable<Carta> CartasRegistradas => cartas;


        public static Carta GetCarta(int id)
           => cartas.Find(c => c.CartaId == id);

        public static void EliminarCarta(Carta carta)
            => cartas.Remove(carta);

        public static void ActualizarCarta(Carta carta)
        {
            var indice = cartas.FindIndex(c => c.CartaId == carta.CartaId);
            if (indice != -1)
            {
                cartas[indice] = carta;
            }
        }
    }
}
