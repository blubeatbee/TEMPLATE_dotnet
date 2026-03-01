using Microsoft.EntityFrameworkCore;
using Source.Models;

namespace Source.Data;
public partial class ApplicationDbContext : DbContext
{
   public ApplicationDbContext()
	{
	}

   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

   public virtual DbSet<EntityExample> EntityExamples { get; set; }

	// Requires testing:
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			.AddJsonFile("appsettings.json")
			.Build();
		optionsBuilder.UseSqlServer(configuration.GetConnectionString("ApplicationDbContextConnection"));
		
		AppSettings settings = new AppSettings();
		optionsBuilder.UseMySql(configuration.GetConnectionString(settings.BuildConnectionString()));
	}

   protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<EntityExample>(entity =>
		{
		});
	}
}
