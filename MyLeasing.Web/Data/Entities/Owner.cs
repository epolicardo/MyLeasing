using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]

        public string Document { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [MaxLength(20)]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }
        [MaxLength(20)]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }
        public string Address { get; set; }
        //Propiedades de solo lectura - No Mapean en DB
        [Display(Name ="Full Name")]
        public string FullName => $"{FirstName} {LastName}";
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

    }
}
