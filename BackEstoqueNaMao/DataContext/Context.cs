using Microsoft.EntityFrameworkCore;
using BackEstoqueNaMao.Models;

namespace BackEstoqueNaMao.DataContext;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options)
        : base(options)
    { }

    public DbSet<Client> Clients { get; set; }
}