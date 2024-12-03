namespace GearWebApp.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
