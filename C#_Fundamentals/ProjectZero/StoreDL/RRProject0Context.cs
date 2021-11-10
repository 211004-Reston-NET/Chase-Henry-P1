using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StoreModels;

#nullable disable

namespace StoreDL
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

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<LineItems> LineItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }

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
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();
            });

            modelBuilder.Entity<LineItems>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__LineItem__56A128AAC85AB9FF");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                // entity.HasOne(d => d.Orders)
                //     .WithMany(p => p.LineItems)
                //     .HasForeignKey(d => d.OrderId)
                //     .HasConstraintName("FK__LineItems__order__6EF57B66");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__0809335D6AC1256C");
                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.CustId).HasColumnName("custId");

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                entity.Property(e => e.prodId).HasColumnName("prodId");

                // entity.HasOne(d => d.Cust)
                //     .WithMany(p => p.Orders)
                //     .HasForeignKey(d => d.CustId)
                //     .HasConstraintName("FK__Orders__custId__6B24EA82");

                // entity.HasOne(d => d.Store)
                //     .WithMany(p => p.Orders)
                //     .HasForeignKey(d => d.StoreId)
                //     .HasConstraintName("FK__Orders__storeId__76969D2E");

                // entity.HasOne(d => d.prod)
                //     .WithMany(p => p.Orders)
                //     .HasForeignKey(d => d.prodId)
                //     .HasConstraintName("FK__Orders__prodId__7C4F7684");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Products__319F67F1A9BAEBCA");

                entity.Property(e => e.ProdId).HasColumnName("prodId");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("storeId");

                // entity.HasOne(d => d.Item)
                //     .WithMany(p => p.Products)
                //     .HasForeignKey(d => d.ItemId)
                //     .HasConstraintName("FK__Products__itemId__797309D9");

                // entity.HasOne(d => d.Store)
                //     .WithMany(p => p.Products)
                //     .HasForeignKey(d => d.StoreId)
                //     .HasConstraintName("FK__Products__storeI__7A672E12");
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

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                // entity.HasOne(d => d.Order)
                //     .WithMany(p => p.StoreFronts)
                //     .HasForeignKey(d => d.OrderId)
                //     .HasConstraintName("FK__StoreFron__order__71D1E811");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
