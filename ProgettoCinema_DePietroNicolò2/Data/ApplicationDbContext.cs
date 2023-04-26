using ProgettoCinema_DePietroNicolò2.Models;
using Microsoft.EntityFrameworkCore;

namespace ProgettoCinema_DePietroNicolò2.Data;
public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Utente> Utenti { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}