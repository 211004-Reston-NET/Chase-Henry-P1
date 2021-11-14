using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreDL.Entities
{
    public partial class RRProject0Context : DbContext
    {
        public RRProject0Context()
        {
        }

        public RRProject0Context(DbContextOptions<RRProject0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__9725F2C6D6966B7D");

                entity.ToTable("Customer");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineItem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__LineItem__56A128AAF1727694");

                entity.Property(e => e.ItemId).HasColumnName("itemId");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.ProdId).HasColumnName("prodId");

                entity.Property(e => e.StoreId).HasColumnName("storeId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Products__319F67F1A9BAEBCA");

                entity.Property(e => e.ProdId).HasColumnName("prodId");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__Products__itemId__0B91BA14");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__StoreFro__1EA716133BA25C2C");

                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserProf__1788CC4C05D5DA4E");

                entity.ToTable("UserProfile");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
