using LinqCrowdfundingWpf.Models;

namespace LinqCrowdfundingWpf.Services;

public static class DemoData
{
    public static List<Project> Projects => new()
    {
        new(){ProjectId=1,Title="EcoBottle",Category="Стартап",TargetAmount=150000,StartDate=new(2026,1,10),Status="Активен"},
        new(){ProjectId=2,Title="GreenRoof",Category="Социальный",TargetAmount=90000,StartDate=new(2026,1,15),Status="Активен"},
        new(){ProjectId=3,Title="SmartFarm",Category="Стартап",TargetAmount=220000,StartDate=new(2026,2,1),Status="Активен"},
        new(){ProjectId=4,Title="BookBus",Category="Социальный",TargetAmount=70000,StartDate=new(2026,2,5),Status="Завершён"},
        new(){ProjectId=5,Title="SolarKit",Category="Стартап",TargetAmount=180000,StartDate=new(2026,2,12),Status="Активен"},
        new(){ProjectId=6,Title="CleanRiver",Category="Социальный",TargetAmount=120000,StartDate=new(2026,2,20),Status="Активен"},
        new(){ProjectId=7,Title="ArtSpace",Category="Творческий",TargetAmount=60000,StartDate=new(2026,3,1),Status="Активен"},
        new(){ProjectId=8,Title="MedHelp",Category="Социальный",TargetAmount=250000,StartDate=new(2026,3,8),Status="Активен"},
        new(){ProjectId=9,Title="DroneMap",Category="Стартап",TargetAmount=300000,StartDate=new(2026,3,15),Status="Активен"},
        new(){ProjectId=10,Title="LocalFood",Category="Творческий",TargetAmount=50000,StartDate=new(2026,3,22),Status="Завершён"},
        new(){ProjectId=11,Title="ReUse",Category="Социальный",TargetAmount=80000,StartDate=new(2026,4,1),Status="Активен"},
        new(){ProjectId=12,Title="LearnCode",Category="Стартап",TargetAmount=175000,StartDate=new(2026,4,5),Status="Активен"}
    };

    public static List<Backer> Backers => new()
    {
        new(){BackerId=1,Name="Анна Смирнова",City="Хельсинки",ContributionCount=3,Email="anna@example.com",RegisteredAt=new(2025,11,1)},
        new(){BackerId=2,Name="Иван Петров",City="Тампере",ContributionCount=2,Email="ivan@example.com",RegisteredAt=new(2025,11,5)},
        new(){BackerId=3,Name="Мария Ким",City="Турку",ContributionCount=4,Email="maria@example.com",RegisteredAt=new(2025,11,8)},
        new(){BackerId=4,Name="Олег Волков",City="Хельсинки",ContributionCount=1,Email="oleg@example.com",RegisteredAt=new(2025,11,10)},
        new(){BackerId=5,Name="Елена Орлова",City="Эспоо",ContributionCount=3,Email="elena@example.com",RegisteredAt=new(2025,11,12)},
        new(){BackerId=6,Name="Дмитрий Соколов",City="Тампере",ContributionCount=2,Email="dmitry@example.com",RegisteredAt=new(2025,11,15)},
        new(){BackerId=7,Name="София Ли",City="Турку",ContributionCount=2,Email="sofia@example.com",RegisteredAt=new(2025,11,18)},
        new(){BackerId=8,Name="Павел Морозов",City="Хельсинки",ContributionCount=5,Email="pavel@example.com",RegisteredAt=new(2025,11,20)},
        new(){BackerId=9,Name="Ирина Белова",City="Эспоо",ContributionCount=1,Email="irina@example.com",RegisteredAt=new(2025,11,22)},
        new(){BackerId=10,Name="Максим Кузнецов",City="Тампере",ContributionCount=3,Email="max@example.com",RegisteredAt=new(2025,11,25)},
        new(){BackerId=11,Name="Наталья Фёдорова",City="Турку",ContributionCount=2,Email="natalia@example.com",RegisteredAt=new(2025,12,1)},
        new(){BackerId=12,Name="Алексей Громов",City="Хельсинки",ContributionCount=4,Email="alex@example.com",RegisteredAt=new(2025,12,3)}
    };

    public static List<Donation> Donations => new()
    {
        new(){DonationId=1,ProjectId=1,BackerId=1,Amount=12000,DonationDate=new(2026,4,1),PaymentMethod="Карта"},
        new(){DonationId=2,ProjectId=1,BackerId=2,Amount=8000,DonationDate=new(2026,4,2),PaymentMethod="PayPal"},
        new(){DonationId=3,ProjectId=2,BackerId=3,Amount=15000,DonationDate=new(2026,4,3),PaymentMethod="Карта"},
        new(){DonationId=4,ProjectId=3,BackerId=4,Amount=25000,DonationDate=new(2026,4,4),PaymentMethod="Банк"},
        new(){DonationId=5,ProjectId=3,BackerId=5,Amount=18000,DonationDate=new(2026,4,5),PaymentMethod="Карта"},
        new(){DonationId=6,ProjectId=4,BackerId=6,Amount=7000,DonationDate=new(2026,4,6),PaymentMethod="PayPal"},
        new(){DonationId=7,ProjectId=5,BackerId=7,Amount=30000,DonationDate=new(2026,4,7),PaymentMethod="Карта"},
        new(){DonationId=8,ProjectId=6,BackerId=8,Amount=11000,DonationDate=new(2026,4,8),PaymentMethod="Банк"},
        new(){DonationId=9,ProjectId=7,BackerId=9,Amount=5000,DonationDate=new(2026,4,9),PaymentMethod="Карта"},
        new(){DonationId=10,ProjectId=8,BackerId=10,Amount=40000,DonationDate=new(2026,4,10),PaymentMethod="PayPal"},
        new(){DonationId=11,ProjectId=9,BackerId=11,Amount=22000,DonationDate=new(2026,4,11),PaymentMethod="Карта"},
        new(){DonationId=12,ProjectId=10,BackerId=12,Amount=6000,DonationDate=new(2026,4,12),PaymentMethod="Банк"},
        new(){DonationId=13,ProjectId=11,BackerId=1,Amount=9000,DonationDate=new(2026,4,13),PaymentMethod="Карта"},
        new(){DonationId=14,ProjectId=12,BackerId=2,Amount=17000,DonationDate=new(2026,4,14),PaymentMethod="PayPal"},
        new(){DonationId=15,ProjectId=2,BackerId=5,Amount=13000,DonationDate=new(2026,4,15),PaymentMethod="Карта"},
        new(){DonationId=16,ProjectId=5,BackerId=8,Amount=14000,DonationDate=new(2026,4,16),PaymentMethod="Банк"},
        new(){DonationId=17,ProjectId=8,BackerId=3,Amount=21000,DonationDate=new(2026,4,17),PaymentMethod="Карта"},
        new(){DonationId=18,ProjectId=9,BackerId=10,Amount=16000,DonationDate=new(2026,4,18),PaymentMethod="PayPal"},
        new(){DonationId=19,ProjectId=12,BackerId=6,Amount=10000,DonationDate=new(2026,4,19),PaymentMethod="Карта"},
        new(){DonationId=20,ProjectId=6,BackerId=11,Amount=7500,DonationDate=new(2026,4,20),PaymentMethod="Банк"}
    };
}
