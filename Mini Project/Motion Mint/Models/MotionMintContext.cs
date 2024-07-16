using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Motion_Mint.Models;

public partial class MotionMintContext : DbContext
{
    public MotionMintContext()
    {
    }

    public MotionMintContext(DbContextOptions<MotionMintContext> options)
        : base(options)
    {
    }
   
    public virtual DbSet<Carreg> Carregs { get; set; }
     public DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Rental> Rentals { get; set; }

    public virtual DbSet<Returncar> Returncars { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MsSqlLocalDb;Initial Catalog=MotionMint;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carreg>(entity =>
        {
         

            entity.HasKey(e => e.Id).HasName("PK__carreg__3214EC070A0C06C5");

            entity.ToTable("carreg");

            entity.Property(e => e.Available)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("available");
            entity.Property(e => e.Carno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carno");
            entity.Property(e => e.Make)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("make");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("model");
        });
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Email);
            entity.ToTable("Admin"); // Specify the table name here
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3214EC078DEBBCDE");

            entity.ToTable("customer");

            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Custname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custname");
            entity.Property(e => e.Mobile).HasColumnName("mobile");
        });

        modelBuilder.Entity<Rental>(entity => {
            entity.ToTable("rental");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Carid)
            .HasMaxLength(50);
            entity.Property(e => e.Custid)
            .HasMaxLength(50);
            entity.Property(e => e.Fee)
            .HasMaxLength(50);
            entity.Property(e => e.Sdate)
           .HasMaxLength(50);
            entity.Property(e => e.Edate)
           .HasMaxLength(50);
            // Example configuration entity.Property(e => e.Fee).HasMaxLength(50); 
            // Example configuration });
        });

        modelBuilder.Entity<Returncar>(entity => {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Carno)
            .HasMaxLength(50);
            entity.Property(e => e.Custid)
            .HasMaxLength(50);
            
            entity.Property(e => e.Date)
           .HasMaxLength(50);
            entity.Property(e => e.Elsp)
            .HasMaxLength(50);
            entity.Property(e => e.Fine)
           .HasMaxLength(50);
            // Example configuration entity.Property(e => e.Fee).HasMaxLength(50); 
            // Example configuration });
        });
        OnModelCreatingPartial(modelBuilder);
        
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
