using System.ComponentModel.DataAnnotations;

namespace Actividad17.Data
{
    public class Productos
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Excede el maximo de caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria")]
        [StringLength(100, ErrorMessage = "Excede el maximo de caracteres")]
        public string? Descripcion { get; set;}
        [RegularExpression("^[0-9]+$", ErrorMessage = "Solo se permiten valores numéricos")]
        [Required(ErrorMessage = "El costo es obligatorio")]
        public int Costo { get; set;}
    }
}
