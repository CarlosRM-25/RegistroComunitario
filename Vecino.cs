using System.ComponentModel.DataAnnotations;

namespace RegistroComunitario.Models
{
    public class Vecino
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La identificación es obligatoria.")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MinLength(3, ErrorMessage = "Debe tener al menos 3 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [MinLength(3, ErrorMessage = "Debe tener al menos 3 caracteres.")]
        public string Apellidos { get; set; }

        [Phone(ErrorMessage = "Formato de teléfono inválido.")]
        public string Telefono { get; set; }

        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un género.")]
        public string Genero { get; set; }

        [Range(1, 120, ErrorMessage = "Edad entre 1 y 120 años.")]
        public int Edad { get; set; }
    }
}
