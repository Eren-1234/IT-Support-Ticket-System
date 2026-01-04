namespace DestekSistemi.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Bekliyor"; // Bekliyor, Çözüldü
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // İlişkiler (Kimin talebi?)
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}