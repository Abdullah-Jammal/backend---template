# BackendTemplate (ASP.NET 10, Clean Architecture)

This repository contains a clean architecture starter template with four projects:

- `BackendTemplate.API`: presentation layer (`Controllers`, DI composition root)
- `BackendTemplate.Domain`: enterprise business entities and core models
- `BackendTemplate.Application`: use-cases, abstractions, and application services
- `BackendTemplate.Infrastructure`: data access and external implementations

## Included infrastructure packages

The Infrastructure project includes EF Core and ASP.NET Core Identity packages:

- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Design`
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore`

`ApplicationDbContext` inherits from `IdentityDbContext<IdentityUser>` and is wired up in `AddInfrastructure(...)` with SQL Server and Identity Core.

## Notes

- The solution targets `.NET 10` (`net10.0`) and preview package versions.
- Update package versions if you want to align with newer preview/GA SDK releases.
