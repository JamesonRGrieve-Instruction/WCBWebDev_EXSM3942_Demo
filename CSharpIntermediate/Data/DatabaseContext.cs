using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3. Apply the appropriate using statements:
using Microsoft.EntityFrameworkCore;

// 1. Change the namespace to the same as our models.
namespace CSharpIntermediate.Models
{
    // 2. Change the default "internal" to "public", and apply the partial modifier.
    // 4. Inherit from DbContext.
    public partial class DatabaseContext : DbContext
    {
        // 5. Create constructors for both options and no options.
        // This allows us to create a context either in the default state, or a customized one.
        public DatabaseContext()
        { 
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // 6. Create database sets for each table we plan to include.
        public virtual DbSet<Product> Products { get; set; }

        // 7. Generate a OnConfiguring method:
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            // 10. Connect to the database.
            if (!optionBuilder.IsConfigured) optionBuilder.UseMySql("server=localhost;port=3306;user=root;database=ef_demo", new MySqlServerVersion(new Version(10, 4, 24)));
        }

        // 8. Generate a OnModelCreating method:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 9. Set character set and collation for ALL string properties/columns.
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
