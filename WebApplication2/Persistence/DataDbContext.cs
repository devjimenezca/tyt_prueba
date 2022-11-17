


using Microsoft.EntityFrameworkCore;
using WebApplication2.Domain;
using WebApplication2.Domain.Common;


namespace WebApplication2.Persistence
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                 UseSqlServer(@"Data Source=DESKTOP-L94Q7CS\MSSQLSERVER2019;Initial Catalog=TYT_PRUEBA;Integrated Security=True User Id=sa;Password=12345;")
               .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information)
               .EnableSensitiveDataLogging();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                switch (entry.State)
                { 
                    case EntityState.Added:
                        entry.Entity.CreatedDate =  DateTime.Now;
                        entry.Entity.CreatedBy = "system";
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "system";
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>()
            .HasData(
                 new Departamento { CreatedBy = "System", Id=1, Codigo = "123", Nombre = "Sistema", Estado = true },
                new Departamento { CreatedBy = "System", Id = 2, Codigo = "124", Nombre = "Talento Humano", Estado = true });
            modelBuilder.Entity<Cargo>()
            .HasData(
                 new Cargo { CreatedBy = "System", Id = 1, Codigo = "991", Nombre = "Desarrollador", Estado = true },
                new Cargo { CreatedBy = "System", Id = 2, Codigo = "992", Nombre = "Lider de Proyecto", Estado = true });
        }



        public DbSet<Cargo>? Cargo { get; set; }

        public DbSet<Departamento>? Departamento { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }



    }
}
