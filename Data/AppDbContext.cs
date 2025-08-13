using System;
using DockerComposeAPIDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeAPIDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TodoItem>().HasData(
            new TodoItem { Id = 1, Title = "Learn Docker", IsComplete = false },
            new TodoItem { Id = 2, Title = "Containerize .NET API", IsComplete = true },
            new TodoItem { Id = 3, Title = "Run SQL Server in Docker", IsComplete = false }
        );
    }
}
