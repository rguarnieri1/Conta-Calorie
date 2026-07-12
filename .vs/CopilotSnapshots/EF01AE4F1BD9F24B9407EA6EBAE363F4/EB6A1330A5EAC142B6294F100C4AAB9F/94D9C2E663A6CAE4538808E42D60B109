using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BL.Models;

public partial class ContaCalorieContext : DbContext
{
    public ContaCalorieContext()
    {
    }

    public ContaCalorieContext(DbContextOptions<ContaCalorieContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alimenti> Alimentis { get; set; }

    public virtual DbSet<AlimentiNutrienti> AlimentiNutrientis { get; set; }

    public virtual DbSet<Micronutrienti> Micronutrientis { get; set; }

    public virtual DbSet<MicronutrimentiDefault> MicronutrimentiDefaults { get; set; }

    public virtual DbSet<Pasti> Pastis { get; set; }

    public virtual DbSet<Peso> Pesos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ContaCalorie;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alimenti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alimenti__3214EC277F4ABF77");

            entity.ToTable("Alimenti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlimentiNutrienti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alimenti__3214EC2766DC3C70");

            entity.ToTable("AlimentiNutrienti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdAlimento).HasDefaultValue(0);
            entity.Property(e => e.IdMicronutriente).HasDefaultValue(0);
        });

        modelBuilder.Entity<Micronutrienti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Micronut__3214EC2769F46F9C");

            entity.ToTable("Micronutrienti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Micronutrimenti)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MicronutrimentiDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Micronut__3214EC27E56C81BA");

            entity.ToTable("Micronutrimenti_default");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdMicronutriente).HasColumnName("idMicronutriente");
            entity.Property(e => e.Perc).HasDefaultValue(false);
            entity.Property(e => e.Percentuale).HasDefaultValueSql("(NULL)");
            entity.Property(e => e.Peso).HasDefaultValueSql("(NULL)");

            entity.HasOne(d => d.IdMicronutrienteNavigation).WithMany(p => p.MicronutrimentiDefaults)
                .HasForeignKey(d => d.IdMicronutriente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Micronutrimenti_default_Micronutrienti");
        });

        modelBuilder.Entity<Pasti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pasti__3214EC27D89D118B");

            entity.ToTable("Pasti");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Peso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Peso__3214EC27819B0558");

            entity.ToTable("Peso");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PesoKg).HasDefaultValueSql("(NULL)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
