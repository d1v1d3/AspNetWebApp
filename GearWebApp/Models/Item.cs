using System.ComponentModel.DataAnnotations;
namespace GearWebApp.Models
{
    public class Item
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]  
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<WeaponItem> WeaponItems { get; set; } = new HashSet<WeaponItem>();

    }
}
