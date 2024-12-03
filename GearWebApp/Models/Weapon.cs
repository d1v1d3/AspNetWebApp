using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GearWebApp.Models
{
    public class Weapon
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CotegoryId { get; set; }
        [ForeignKey(nameof(CotegoryId))]
        public virtual Category Category { get; set; }
        public virtual ICollection<WeaponItem> WeaponItems { get; set; } = new HashSet<WeaponItem>();
    }
}
