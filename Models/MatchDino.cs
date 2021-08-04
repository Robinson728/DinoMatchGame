using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoMatchGame.Models
{
    public class MatchDino
    {
        public int Id { get; set; }
        public string Jugador { get; set; }
        public string ModoDeJuego { get; set; }
        public string Dificultad { get; set; }
        public double TiempoJugada { get; set; }
    }
}
