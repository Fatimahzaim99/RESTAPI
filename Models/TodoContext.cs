using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace webapiCDN.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
    : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
