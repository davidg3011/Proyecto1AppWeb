using System.ComponentModel.DataAnnotations;

namespace ShoppingApi_Jueves_2025I.DAL.Entities
{
    public class Country : AuditBase
    {
        [Required (ErrorMessage = "El campo {0} es obligatorio")] //Campo obligatorio
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Caracteres maximos
        [Display(Name = "Pais")] //Para identificar el nombre mas facil
        public string Name { get; set; }

    }
}
