dotnet ef migrations add InitialCreate --project LMS.Data --startup-project WebApplication1

dotnet ef database update --project LMS.Data --startup-project WebApplication1  