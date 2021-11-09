## <div align="center">Ef Core Example</div>
### <div align="center">November 09 2021</div>

# Ef core example guide

## Description
This service is an example of .Net 5 Ef Core with different models and using the **Code First** method to design database tables with both **Data annotation** and **Flent API**.


***
## Technology Stack

1. **[.Net 5 sdk](https://dotnet.microsoft.com/download/dotnet/5.0)** version 5.0.11

2. **[Sql Server 2019](https://docs.microsoft.com/en-us/sql/sql-server/what-s-new-in-sql-server-ver15?view=sql-server-ver15)**

3. **[.Net ef tools](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)** varsion 5.0.11
 
### This service uses the following packages from [nuget](https://www.nuget.org/).

1. **[Microsoft.EntityFrameworkCore](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/)** version 5.0.11

2. **[Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/)** version 5.0.11

3. **[Microsoft.EntityFrameworkCore.Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/)** version 5.0.11
***

## Migration Commands
- First install or update **dotnet ef** : 
```bash
dotnet tool install --global dotnet-ef
```
```bash
dotnet tool update --global dotnet-ef
```
verification 
```bash
dotnet ef

_/\__
               ---==/    \\
         ___  ___   |.    \|\
        | __|| __|  |  )   \\\
        | _| | _|   \_/ |  //|\\
        |___||_|       /   \\\/\\

Entity Framework Core .NET Command-line Tools 2.1.3-rtm-32065

<Usage documentation follows, not shown.>
```

- For add migration in project directory: 
```bash
dotnet ef --startup-project EfCoreExample --project EfCoreExample_DataAccess migrations add "init entities"
```

- For add to database in project directory: 
```bash
dotnet ef --startup-project EfCoreExample --project EfCoreExample_DataAccess database update
```