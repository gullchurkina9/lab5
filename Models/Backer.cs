namespace LinqCrowdfundingWpf.Models;
public class Backer
{
    public int BackerId { get; set; }
    public string Name { get; set; } = "";
    public string City { get; set; } = "";
    public int ContributionCount { get; set; }
    public string Email { get; set; } = "";
    public DateTime RegisteredAt { get; set; }
}
