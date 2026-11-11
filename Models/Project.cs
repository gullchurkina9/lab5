namespace LinqCrowdfundingWpf.Models;
public class Project
{
    public int ProjectId { get; set; }
    public string Title { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal TargetAmount { get; set; }
    public DateTime StartDate { get; set; }
    public string Status { get; set; } = "";
}
