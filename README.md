# CrowdFund Analytics — WPF + LINQ

## Запуск
Требуется Windows и .NET 8 SDK (Desktop development / WPF).
1. Распакуйте архив.
2. Откройте `LinqCrowdfundingWpf.csproj` в Visual Studio 2022.
3. Выберите конфигурацию Debug и нажмите F5.

## Содержание
- 3 связанные сущности: Project, Backer, Donation (по 6 полей).
- 12 проектов, 12 спонсоров, 20 пожертвований.
- LINQ: Where, Select, OrderByDescending, GroupBy, Join, GroupJoin,
  Union, Intersect, Except, All, Any, Contains, Count, Sum, Min, Max, Average.
- Результаты отображаются в DataGrid; запросы запускаются кнопками.
