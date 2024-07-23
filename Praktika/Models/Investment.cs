namespace Praktika.Models
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CompanyId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

    public User User { get; set; }
    public Company Company { get; set; }
}
