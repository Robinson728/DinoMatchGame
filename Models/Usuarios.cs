using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DinoMatchGame.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreDeUsuario { get; set; }
        public string MejorPuntuación { get; set; }
        public int VecesJugado { get; set; }


    }
}
