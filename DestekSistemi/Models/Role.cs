namespace DestekSistemi.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; } // Admin, IT, Employee
        public virtual ICollection<User>? Users { get; set; } // İlişki
    }
}
