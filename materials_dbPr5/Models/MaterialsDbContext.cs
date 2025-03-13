using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace materials_dbPr5.Models;

public partial class MaterialsDbContext : DbContext
{
    public MaterialsDbContext()
    {
    }

    public MaterialsDbContext(DbContextOptions<MaterialsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MaterialType> MaterialTypes { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierType> SupplierTypes { get; set; }

    public virtual DbSet<SuppliersMaterial> SuppliersMaterials { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=materials_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("materials_pkey");

            entity.ToTable("materials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CountInPack).HasColumnName("count_in_pack");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.IdMaterialType).HasColumnName("id_material_type");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.NameMaterial).HasColumnName("name_material");

            entity.HasOne(d => d.IdMaterialTypeNavigation).WithMany(p => p.Materials)
                .HasForeignKey(d => d.IdMaterialType)
                .HasConstraintName("materials_id_material_type_fkey");
        });

        modelBuilder.Entity<MaterialType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("material_types_pkey");

            entity.ToTable("material_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeMaterial).HasColumnName("type_material");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdSupplierType).HasColumnName("id_supplier_type");
            entity.Property(e => e.Inn).HasColumnName("inn");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.NameSupplier).HasColumnName("name_supplier");

            entity.HasOne(d => d.IdSupplierTypeNavigation).WithMany(p => p.Suppliers)
                .HasForeignKey(d => d.IdSupplierType)
                .HasConstraintName("suppliers_id_supplier_type_fkey");
        });

        modelBuilder.Entity<SupplierType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("supplier_types_pkey");

            entity.ToTable("supplier_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TypeSupplier).HasColumnName("type_supplier");
        });

        modelBuilder.Entity<SuppliersMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_materials_pkey");

            entity.ToTable("suppliers_materials");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CostForPack)
                .HasColumnType("money")
                .HasColumnName("cost_for_pack");
            entity.Property(e => e.CountPack).HasColumnName("count_pack");
            entity.Property(e => e.DateOfSupply).HasColumnName("date_of_supply");
            entity.Property(e => e.IdMaterial).HasColumnName("id_material");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.QualitySupply).HasColumnName("quality_supply");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.SuppliersMaterials)
                .HasForeignKey(d => d.IdMaterial)
                .HasConstraintName("suppliers_materials_id_material_fkey");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.SuppliersMaterials)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("suppliers_materials_id_supplier_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
