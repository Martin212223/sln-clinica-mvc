using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        //[RegularExpression("@([A]{2})+([1-9]{4})")]
        [RegularExpression("[a-zA-Z]{2}[1-9]{4}$")]
        public string Matricula { get; set; }

    }

}
