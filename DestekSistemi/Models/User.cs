using System.Net.Sockets;

namespace DestekSistemi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Basit tutuyoruz

        // İlişkiler (Foreign Key)
        public int RoleId { get; set; }
        public virtual Role? Role { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
    }
}