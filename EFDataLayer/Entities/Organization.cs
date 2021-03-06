using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Organization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "Varchar(50)")]

        public Employee Employee { get; set; }
    }
}
