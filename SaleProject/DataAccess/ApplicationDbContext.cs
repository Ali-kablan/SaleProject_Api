using Microsoft.EntityFrameworkCore;
using SaleProject.Entities;

namespace SaleProject.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        // The constructor that receives the configuration options from the application's setup
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }                                                                                                                                                                                                                                                                                                                              

        // Create a DbSet for each entity. Each DbSet corresponds to a table in your database.
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<SaleInvoiceProducts> SaleInvoiceProduct { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<PurchaseInvoiceProducts> PurchaseInvoiceProduct { get; set; }
        public DbSet<StoreStock> StoreStocks { get; set; }
        // --- Add the new DbSets ---
        public DbSet<CustomerContactInfo> CustomerContactInfos { get; set; }
        public DbSet<SupplierContactInfo> SupplierContactInfos { get; set; }

        // This method is used for more advanced configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            // this represent the one to one relationship between Supplier and  SupplierContactInfo
            modelBuilder.Entity<Customer>()
           .HasMany(c => c.ContactInfo)
           .WithOne(ci => ci.Customer)
            .HasForeignKey(ci => ci.CustomerId);

            modelBuilder.Entity<Supplier>()
            .HasMany(s => s.ContactInfo)
            .WithOne(si => si.Supplier)
             .HasForeignKey(si => si.SupplierId);

            // Here we configure the "many-to-many" join tables by defining their composite primary keys.
            // This tells EF Core that the primary key of StoreStock is the combination of StoreId and ProductId.

            modelBuilder.Entity<StoreStock>()
                .HasKey(sp => new { sp.StoreId, sp.ProductId });
        }
    }
}
