using System.ComponentModel.DataAnnotations.Schema;

namespace GearWebApp.Models
{
    public class WeaponItem
    {
        public Guid WeaponId { get; set; }
        [ForeignKey(nameof(WeaponId))]
        public Weapon Weapon { get; set; }
        public Guid ItemId { get; set; }
        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }
    }
}
