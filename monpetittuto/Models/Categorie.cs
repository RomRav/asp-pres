using System.ComponentModel.DataAnnotations;

namespace monpetittuto.Models
{
    public class Categorie
    {
        [Key]
        [Display(Name = "Identifiant")]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
    }
}
