using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TecgurusMiddleEntity
{
    public partial class DBContextUAM : DbContext
    {
        public DBContextUAM()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ClientDetail> ClientDetails { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FederalEntity> FederalEntities { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Order_Details> Order_Details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
        public virtual DbSet<Laptop> Laptops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.SecondlastName)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Municipality)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Colony)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.SuiteNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ClientDetail>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.SecondlastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientDetails)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerDemographic>()
                .Property(e => e.CustomerTypeID)
                .IsFixedLength();

            modelBuilder.Entity<CustomerDemographic>()
                .HasMany(e => e.Customers)
                .WithMany(e => e.CustomerDemographics)
                .Map(m => m.ToTable("CustomerCustomerDemo").MapLeftKey("CustomerTypeID").MapRightKey("CustomerID"));

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Territories)
                .WithMany(e => e.Employees)
                .Map(m => m.ToTable("EmployeeTerritories").MapLeftKey("EmployeeID").MapRightKey("TerritoryID"));

            modelBuilder.Entity<FederalEntity>()
                .Property(e => e.FederalEntityName)
                .IsUnicode(false);

            modelBuilder.Entity<FederalEntity>()
                .HasMany(e => e.ClientDetails)
                .WithRequired(e => e.FederalEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FederalEntity>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.FederalEntity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SecondlastName)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.FiscalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Municipality)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Colony)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SuiteNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.BusinessName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.SecondlastName)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.FiscalPerson)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Municipality)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Colony)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.SuiteNumber)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.LevelExc)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.CallSite)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.StackTrace)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.InnerException)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.AdditionalInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<Order_Details>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerID)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.Freight)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Order>()
                .Property(e => e.ShipName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.SecondlastName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Municipality)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Colony)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.SuiteNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.CartItems)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order_Details)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Region>()
                .Property(e => e.RegionDescription)
                .IsFixedLength();

            modelBuilder.Entity<Region>()
                .HasMany(e => e.Territories)
                .WithRequired(e => e.Region)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipper>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Shipper)
                .HasForeignKey(e => e.ShipVia);

            modelBuilder.Entity<Territory>()
                .Property(e => e.TerritoryDescription)
                .IsFixedLength();

            modelBuilder.Entity<Laptop>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Laptop>()
                .Property(e => e.ProductDescription)
                .IsUnicode(false);
        }
    }
}
