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

    public virtual DbSet<Casting> Castings { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DomainesMetier> DomainesMetiers { get; set; }

    public virtual DbSet<Métier> Métiers { get; set; }

    public virtual DbSet<Offrecasting> Offrecastings { get; set; }

    public virtual DbSet<Pack> Packs { get; set; }

    public virtual DbSet<TypeContrat> TypeContrats { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=localhost;Database=megacasting; user=root; password=");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Casting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("casting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdresseCasting)
                .HasMaxLength(105)
                .HasColumnName("Adresse_casting");
            entity.Property(e => e.FaxCasting).HasColumnName("Fax_Casting");
            entity.Property(e => e.MailCasting)
                .HasMaxLength(20)
                .HasColumnName("Mail_Casting");
            entity.Property(e => e.TelCasting).HasColumnName("Tel_casting");
            entity.Property(e => e.UrlCasting)
                .HasMaxLength(50)
                .HasColumnName("URL_Casting");
        });

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

        modelBuilder.Entity<DomainesMetier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("domaines_metiers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SecteurActiviter)
                .HasMaxLength(50)
                .HasColumnName("Secteur_Activiter");
        });

        modelBuilder.Entity<Métier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("métier");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NomMetier).HasColumnName("Nom_Metier");
            entity.Property(e => e.SalaireMetier).HasColumnName("Salaire_Metier");
            entity.Property(e => e.TypeMetier).HasColumnName("Type_Metier");
        });

        modelBuilder.Entity<Offrecasting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("offrecasting");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coordonnées)
                .HasMaxLength(100)
                .HasColumnName("coordonnées");
            entity.Property(e => e.DateDébutContrat)
                .HasColumnType("date")
                .HasColumnName("dateDébutContrat");
            entity.Property(e => e.DateDébutPublication)
                .HasColumnType("date")
                .HasColumnName("dateDébutPublication");
            entity.Property(e => e.DescriptionPoste)
                .HasMaxLength(100)
                .HasColumnName("descriptionPoste");
            entity.Property(e => e.DescriptionProfil)
                .HasMaxLength(100)
                .HasColumnName("descriptionProfil");
            entity.Property(e => e.DomaineMetier)
                .HasMaxLength(100)
                .HasColumnName("domaineMetier");
            entity.Property(e => e.DuréeDiffusion)
                .HasMaxLength(6)
                .HasColumnName("duréeDiffusion");
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

        modelBuilder.Entity<Pack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pack");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PrixPack).HasColumnName("Prix_Pack");
            entity.Property(e => e.TempsPack)
                .HasMaxLength(6)
                .HasColumnName("Temps_Pack");
            entity.Property(e => e.TypePack)
                .HasMaxLength(50)
                .HasColumnName("Type_Pack");
        });

        modelBuilder.Entity<TypeContrat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("type_contrat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConditionContrat)
                .HasColumnType("mediumtext")
                .HasColumnName("Condition_Contrat");
            entity.Property(e => e.SalaireContrat).HasColumnName("Salaire_Contrat");
            entity.Property(e => e.TempsContrat)
                .HasMaxLength(6)
                .HasColumnName("Temps_Contrat");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("utilisateur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Mail).HasMaxLength(30);
            entity.Property(e => e.Mdp)
                .HasMaxLength(20)
                .HasColumnName("MDP");
            entity.Property(e => e.Pseudo).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
