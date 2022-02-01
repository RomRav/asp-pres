using System.ComponentModel.DataAnnotations;

namespace monpetittuto.Models
{
    public class ShopModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ShopModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
