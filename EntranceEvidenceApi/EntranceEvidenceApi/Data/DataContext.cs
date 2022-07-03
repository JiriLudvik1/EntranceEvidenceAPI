using EntranceEvidenceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EntranceEvidenceApi.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }
    public DbSet<Gate> Gates { get; set; }
    public DbSet<RFIDTag> Tags { get; set; }
  }
}
