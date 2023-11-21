using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MegaCasting.DBLib.Class;

public partial class MegacastingContext : DbContext
{
    public MegacastingContext()
    {
    }

    public MegacastingContext(DbContextOptions<MegacastingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Listereferentiel> Listereferentiels { get; set; }

    public virtual DbSet<Offrecasting> Offrecastings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=megacasting;user=root;password=;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdresseEntreprise)
                .HasMaxLength(100)
                .HasColumnName("adresseEntreprise");
            entity.Property(e => e.AdresseMail)
                .HasMaxLength(10)
                .HasColumnName("adresseMail");
            entity.Property(e => e.CodePostal).HasColumnName("codePostal");
            entity.Property(e => e.NomEntreprise)
                .HasMaxLength(200)
                .HasColumnName("nomEntreprise");
            entity.Property(e => e.NumeroTelephone).HasColumnName("numeroTelephone");
            entity.Property(e => e.SirenEntreprise).HasColumnName("sirenEntreprise");
            entity.Property(e => e.SiretEntreprise).HasColumnName("siretEntreprise");
            entity.Property(e => e.Ville)
                .HasMaxLength(100)
                .HasColumnName("ville");
        });

        modelBuilder.Entity<Listereferentiel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("listereferentiel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DomainesMetier)
                .HasMaxLength(50)
                .HasColumnName("domainesMetier");
            entity.Property(e => e.Metier)
                .HasMaxLength(50)
                .HasColumnName("metier");
            entity.Property(e => e.TypesContrat)
                .HasMaxLength(50)
                .HasColumnName("typesContrat");
        });

        modelBuilder.Entity<Offrecasting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("offrecasting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coordonnées)
                .HasMaxLength(100)
                .HasColumnName("coordonnées");
            entity.Property(e => e.DescriptionPoste)
                .HasMaxLength(100)
                .HasColumnName("descriptionPoste");
            entity.Property(e => e.DescriptionProfil)
                .HasMaxLength(100)
                .HasColumnName("descriptionProfil");
            entity.Property(e => e.DomaineMetier)
                .HasMaxLength(100)
                .HasColumnName("domaineMetier");
            entity.Property(e => e.Intitulé)
                .HasMaxLength(100)
                .HasColumnName("intitulé");
            entity.Property(e => e.Localisation)
                .HasMaxLength(100)
                .HasColumnName("localisation");
            entity.Property(e => e.Métier)
                .HasMaxLength(100)
                .HasColumnName("métier");
            entity.Property(e => e.NombrePoste).HasColumnName("nombrePoste");
            entity.Property(e => e.Référence).HasColumnName("référence");
            entity.Property(e => e.TypeContrat)
                .HasMaxLength(100)
                .HasColumnName("typeContrat");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
