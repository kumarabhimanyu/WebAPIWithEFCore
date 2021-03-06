using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataLayer.Entities
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "Varchar(50)")]
        public string? Address { get; set; }
        public ICollection<Organization> OrganizationList { get; set; }

    }
}
