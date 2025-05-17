using System.ComponentModel.DataAnnotations;

namespace ShoppingApi_Jueves_2025I.DAL.Entities
{
    public class AuditBase
    {
        [Key] //PK
        [Required] //Significa que es un campo obligatorio
        public virtual Guid Id { get; set; } //Sera el PK de todas las tablas

        public virtual DateTime? CreatedDate { get; set; } //Para guardar todo registro nuevo con su date

        public virtual DateTime? ModifiedDate { get; set; } //Para guardar todo registro que se modifico con su date
    }
}
