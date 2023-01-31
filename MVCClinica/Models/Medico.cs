using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCClinica.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [RegularExpression("[a-zA-Z]{2}[1-9]{4}$")]
        public string Matricula { get; set; }

    }

}
