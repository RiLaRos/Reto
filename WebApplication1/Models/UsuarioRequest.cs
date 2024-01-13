using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UsuarioRequest
    {
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de 50 caracteres")]
        public string Nombres { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un máximo de 50 caracteres")]
        public string Apellidos { get; set; }

        [Range(18, 60, ErrorMessage = "El campo {0} debe tener un valor entre 18 y 60")]
        public int Edad { get; set; }
    }
}
