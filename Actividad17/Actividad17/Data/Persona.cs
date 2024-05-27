using System.ComponentModel.DataAnnotations;

namespace Actividad17.Data
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El Correo es requerido")]
        [StringLength(100, ErrorMessage = "La longitud maxima es 100")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        public string? Correo { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Debe contener solo números")]
        [Required(ErrorMessage = "El Telefono es requerido")]
        public string? Telefono { get; set; }
        
        public string? Direccion { get; set; }

        //Propiedad de navegacion
      

        // para leer los datos de pedido desde nuestra tabla persona

        
    }
}
