using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }


    //dotnet ef migrations add InitialCreate -o Data/Migrations
    //dotnet ef database update
    //that command uses the initialcreate migration to create the database
    //use dotnet ef migrations remove to remove the last migration
    //use dotnet migrations list to see all migrations
    //use dotnet ef database update for committing subsequent migrations

}