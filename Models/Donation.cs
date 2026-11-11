namespace LinqCrowdfundingWpf.Models;
public class Donation
{
    public int DonationId { get; set; }
    public int ProjectId { get; set; }
    public int BackerId { get; set; }
    public decimal Amount { get; set; }
    public DateTime DonationDate { get; set; }
    public string PaymentMethod { get; set; } = "";
}
