using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class MarcaBase
    {
        [Required(ErrorMessage = "La propiedad nombre es obligatoria")]
        [StringLength(80, ErrorMessage = "La propiedad nombre debe ser mayor a 2 caracteres y menor a 80", MinimumLength = 2)]
        public string Nombre { get; set; }
    }

    public class MarcaResponse : MarcaBase
    {
        public Guid Id { get; set; }
    }
}
