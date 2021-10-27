using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StoreUI.Entities
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
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ListOfOrders)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("store");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_address");

                entity.Property(e => e.StoreId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
