using System;
using DockerComposeAPIDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerComposeAPIDemo.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<TodoItem> TodoItems { get; set; }
}
