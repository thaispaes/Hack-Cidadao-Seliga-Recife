using Microsoft.EntityFrameworkCore;
using SeLigaRecife.Web.Entities;

namespace SeLigaRecife.Web.Context;

public class SeLigaRecifeDbContext : DbContext
{
    public DbSet<OccurrenceType> OccurrenceTypes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Alert> Alerts { get; set; }

    public SeLigaRecifeDbContext(DbContextOptions<SeLigaRecifeDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Seed

        List<Category> categoriesForSeeds = new();
        categoriesForSeeds.Add(new Category { Id = 1, Name = "Crime" });
        categoriesForSeeds.Add(new Category { Id = 2, Name = "Infraestrutura" });

        List<OccurrenceType> occurrenceTypesForSeeds = new();
        occurrenceTypesForSeeds.Add(new OccurrenceType { Id = 1, Name = "Assalto", CategoryId = 1 });
        occurrenceTypesForSeeds.Add(new OccurrenceType { Id = 2, Name = "Roubo", CategoryId = 1 });
        occurrenceTypesForSeeds.Add(new OccurrenceType { Id = 3, Name = "Depredação", CategoryId = 1 });
        occurrenceTypesForSeeds.Add(new OccurrenceType() { Id = 4, Name = "Iluminação", CategoryId = 2 });
        occurrenceTypesForSeeds.Add(new OccurrenceType() { Id = 5, Name = "Policiamento", CategoryId = 2 });
        occurrenceTypesForSeeds.Add(new OccurrenceType() { Id = 6, Name = "Câmera", CategoryId = 2 });
        occurrenceTypesForSeeds.Add(new OccurrenceType() { Id = 7, Name = "Morador de rua", CategoryId = 2 });
        occurrenceTypesForSeeds.Add(new OccurrenceType() { Id = 8, Name = "Atuação abusiva de Flanelinha", CategoryId = 2 });

        modelBuilder.Entity<Category>().HasData(categoriesForSeeds);
        modelBuilder.Entity<OccurrenceType>().HasData(occurrenceTypesForSeeds);


        #endregion
    }

}