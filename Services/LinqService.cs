using LinqCrowdfundingWpf.Models;

namespace LinqCrowdfundingWpf.Services;

public class LinqService
{
    private readonly List<Project> _projects;
    private readonly List<Backer> _backers;
    private readonly List<Donation> _donations;

    public LinqService(List<Project> projects, List<Backer> backers, List<Donation> donations)
        => (_projects, _backers, _donations) = (projects, backers, donations);

    public IEnumerable<object> ProjectDonations() =>
        from d in _donations
        join p in _projects on d.ProjectId equals p.ProjectId
        join b in _backers on d.BackerId equals b.BackerId
        orderby d.Amount descending
        select new { Проект = p.Title, Спонсор = b.Name, Сумма = d.Amount, Дата = d.DonationDate.ToShortDateString() };

    public IEnumerable<object> CategoryStatistics() =>
        _projects.GroupBy(p => p.Category).Select(g => new {
            Категория = g.Key, Проектов = g.Count(),
            СредняяЦель = g.Average(p => p.TargetAmount),
            Минимум = g.Min(p => p.TargetAmount), Максимум = g.Max(p => p.TargetAmount),
            ВсегоЦелей = g.Sum(p => p.TargetAmount)
        });

    public IEnumerable<object> ProjectTotals() =>
        from p in _projects
        join d in _donations on p.ProjectId equals d.ProjectId into dg
        select new { Проект = p.Title, Цель = p.TargetAmount, Собрано = dg.Sum(x => x.Amount), Донатов = dg.Count() };

    public IEnumerable<object> DonorsWithDonations() =>
        from b in _backers
        join d in _donations on b.BackerId equals d.BackerId into dg
        select new { Спонсор = b.Name, Город = b.City, Количество = dg.Count(), Внесено = dg.Sum(x => x.Amount) };

    public IEnumerable<object> FilteredProjects() =>
        _projects.Where(p => p.TargetAmount >= 100000 && p.Status == "Активен")
                 .OrderByDescending(p => p.TargetAmount)
                 .Select(p => new { p.Title, p.Category, p.TargetAmount, p.Status });

    public IEnumerable<object> SetOperations()
    {
        var startup = _projects.Where(p => p.Category == "Стартап").Select(p => p.Title);
        var social = _projects.Where(p => p.Category == "Социальный").Select(p => p.Title);
        return new[] {
            new { Операция = "Union (стартапы + социальные)", Результат = string.Join(", ", startup.Union(social)) },
            new { Операция = "Intersect (проекты с целью > 100 000 и активные)", Результат = string.Join(", ", _projects.Where(p=>p.TargetAmount>100000).Select(p=>p.Title).Intersect(_projects.Where(p=>p.Status=="Активен").Select(p=>p.Title))) },
            new { Операция = "Except (все проекты без творческих)", Результат = string.Join(", ", _projects.Select(p=>p.Title).Except(_projects.Where(p=>p.Category=="Творческий").Select(p=>p.Title))) }
        };
    }

    public IEnumerable<object> Conditions()
    {
        var result = new List<object>
        {
            new { Проверка = "All: все проекты имеют положительную цель", Результат = _projects.All(p => p.TargetAmount > 0) },
            new { Проверка = "Any: есть пожертвование более 30 000", Результат = _donations.Any(d => d.Amount > 30000) },
            new { Проверка = "Contains: есть проект EcoBottle", Результат = _projects.Select(p=>p.Title).Contains("EcoBottle") },
            new { Проверка = "Count: количество пожертвований", Результат = _donations.Count },
            new { Проверка = "Sum: собрано всего", Результат = _donations.Sum(d=>d.Amount).ToString("N0") + " ₽" },
            new { Проверка = "Min / Max: сумма пожертвования", Результат = $"{_donations.Min(d=>d.Amount):N0} / {_donations.Max(d=>d.Amount):N0} ₽" },
            new { Проверка = "Average: средний взнос", Результат = $"{_donations.Average(d=>d.Amount):N0} ₽" }
        };
        return result;
    }
}
