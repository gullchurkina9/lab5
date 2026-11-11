using System.Windows;
using LinqCrowdfundingWpf.Services;

namespace LinqCrowdfundingWpf;

public partial class MainWindow : Window
{
    private readonly LinqService _linq = new(DemoData.Projects, DemoData.Backers, DemoData.Donations);
    public MainWindow()
    {
        InitializeComponent();
        Show("Пожертвования: INNER JOIN трёх сущностей", _linq.ProjectDonations());
    }
    private void Show(string title, System.Collections.IEnumerable data)
    {
        ResultTitle.Text = title;
        ResultsGrid.ItemsSource = data;
        StatusText.Text = $"Строк в результате: {ResultsGrid.Items.Count}    |    LINQ to Objects";
    }
    private void Donations_Click(object s, RoutedEventArgs e) => Show("Пожертвования: INNER JOIN Project + Donation + Backer", _linq.ProjectDonations());
    private void Categories_Click(object s, RoutedEventArgs e) => Show("GroupBy + Count / Sum / Min / Max / Average", _linq.CategoryStatistics());
    private void Totals_Click(object s, RoutedEventArgs e) => Show("GroupJoin: сумма и количество пожертвований по проектам", _linq.ProjectTotals());
    private void Backers_Click(object s, RoutedEventArgs e) => Show("GroupJoin: статистика по спонсорам, включая нулевые взносы", _linq.DonorsWithDonations());
    private void Filter_Click(object s, RoutedEventArgs e) => Show("Where + OrderByDescending + Select", _linq.FilteredProjects());
    private void Sets_Click(object s, RoutedEventArgs e) => Show("Union / Intersect / Except", _linq.SetOperations());
    private void Checks_Click(object s, RoutedEventArgs e) => Show("All / Any / Contains + Count / Sum / Min / Max / Average", _linq.Conditions());
}
