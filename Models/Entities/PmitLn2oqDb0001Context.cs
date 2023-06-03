using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Art.Models.Entities;

public partial class PmitLn2oqDb0001Context : DbContext
{
    public PmitLn2oqDb0001Context()
    {
    }

    public PmitLn2oqDb0001Context(DbContextOptions<PmitLn2oqDb0001Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Site> Sites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=93.89.225.198;port=3306;database=pmitLn2oq_db0001;user=pmitLn2oq_user01;password=Ds4FH2f8", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.30-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("site");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Favicon)
                .HasMaxLength(250)
                .HasColumnName("favicon");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .HasColumnName("logo");
            entity.Property(e => e.Logo2)
                .HasMaxLength(250)
                .HasColumnName("logo2");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
