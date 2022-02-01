using System.ComponentModel.DataAnnotations;

namespace monpetittuto.Models
{
    public class Article
    {
        [Key]
        [Display(Name = "Identifiant")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Veuillez saisir un titre pour cette article")]
        [Display(Name ="Titre")]
        [MaxLength(10)]
        [MinLength(5, ErrorMessage = "Titre trop petit")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Veuillez saisir le contenu pour cette article")]
        [Display (Name ="Contenu")]
        public string Content { get; set; }
        [Display (Name = "Date de création")]
        public DateTime DateCreation { get; set; } = DateTime.Now;
        [Display (Name = "Dernière modification")]
        public DateTime DatelastEdit { get; set; }
    }
}
