using Microsoft.EntityFrameworkCore;
using SaleProject.Entities;
using System.Linq.Expressions;

namespace SaleProject.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        // The constructor that receives the configuration options from the application's setup
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public string? CurrentUsername { get; set; } // track user action for audit purposes

        // Create a DbSet for each entity. Each DbSet corresponds to a table in your database.
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<SaleInvoice> SaleInvoices { get; set; }
        public DbSet<SaleInvoiceProducts> SaleInvoiceProducts { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<PurchaseInvoiceProducts> PurchaseInvoiceProducts { get; set; }
        public DbSet<StoreStock> StoreStocks { get; set; }
        // --- Add the new DbSets ---
        public DbSet<CustomerContactInfo> CustomerContactInfos { get; set; }
        public DbSet<SupplierContactInfo> SupplierContactInfos { get; set; }


        



        //public override int SaveChanges()
        //{
         
        //    return base.SaveChanges();
        //}


         // cancellationToken advince topic shuld be understanded soon as we can 
         //public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        //{

        //    return await base.SaveChangesAsync(cancellationToken);
        //}



        // This method is used for more advanced configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // this  from chatgpt and i will ask baltuo for more details
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var isDeletedProp = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
                    var filter = Expression.Lambda(Expression.Equal(isDeletedProp, Expression.Constant(false)), parameter);
                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);
                }
            }


            // this represent the one to many relationship between Supplier and  SupplierContactInfo
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
