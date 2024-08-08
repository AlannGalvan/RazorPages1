using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 60 caracteres.") ]
        [Required(ErrorMessage = "El título es obligatorio.")]
        public string? Titulo { get; set; }

        [Display(Name = "Fecha Lanzamiento")]
        [Required(ErrorMessage ="La fecha de lanzamiento es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaDeLanzamiento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "El género debe comenzar con una letra mayúscula y solo contener letras y espacios.")]
        [Required(ErrorMessage = "El género es obligatorio.")]
        [StringLength(30)]
        public string? Genero { get; set; }

        [Range(1, 100, ErrorMessage = "El precio debe estar entre 1 y 100.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El precio debe ser un número válido con hasta dos decimales.")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser una cantidad válida.")]
        [Column(TypeName = "decimal(18, 2)")]
        [Required(ErrorMessage ="El precio es obligatorio")]
        public decimal Precio { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "El rating debe comenzar con una letra mayúscula y solo contener letras, números, comillas simples, comillas dobles, espacios y guiones.")]
        [StringLength(5, ErrorMessage = "El rating no puede tener más de 5 caracteres.")]
        [Required(ErrorMessage = "El rating es obligatorio.")]
        public string Rating { get; set; } = string.Empty;
    }
}
