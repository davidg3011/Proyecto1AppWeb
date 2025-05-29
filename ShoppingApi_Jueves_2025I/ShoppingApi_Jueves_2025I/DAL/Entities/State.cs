using System.ComponentModel.DataAnnotations;

namespace ShoppingApi_Jueves_2025I.DAL.Entities
{
    public class State : AuditBase
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //Campo obligatorio
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")] //Caracteres maximos
        [Display(Name = "Estado/Departamento")] //Para identificar el nombre mas facil
        public string Name { get; set; }

        //Asi relaciono 2 tablas con EF Core
        [Display(Name = "Pais")]
        public Country? Country { get; set; }

        //FK
        [Display(Name = "Id Pais")]
        public Guid CountryId { get; set; }

    }
}
