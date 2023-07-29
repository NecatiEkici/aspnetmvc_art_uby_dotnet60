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

    public virtual DbSet<About> Abouts { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<Contactform> Contactforms { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Like> Likes { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Slide> Slides { get; set; }

    public virtual DbSet<Subscribe> Subscribes { get; set; }

    public virtual DbSet<Work> Works { get; set; }

    public virtual DbSet<Workcat> Workcats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=93.89.225.198;port=3306;database=pmitLn2oq_db0001;user=pmitLn2oq_user02;password=123456aA+-", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.30-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<About>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("about");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("blog");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Like)
                .HasColumnType("int(11)")
                .HasColumnName("like");
            entity.Property(e => e.Read)
                .HasColumnType("int(11)")
                .HasColumnName("read");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(500)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("comment");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("lastname");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Typeid)
                .HasColumnType("int(11)")
                .HasColumnName("typeid");
        });

        modelBuilder.Entity<Contactform>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contactform");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasColumnName("lastname");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .HasColumnName("subject");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("event");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Dateend)
                .HasColumnType("datetime")
                .HasColumnName("dateend");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Like)
                .HasColumnType("int(11)")
                .HasColumnName("like");
            entity.Property(e => e.Read)
                .HasColumnType("int(11)")
                .HasColumnName("read");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(500)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Like>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("like");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(100)
                .HasColumnName("ip");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
            entity.Property(e => e.Typeid)
                .HasColumnType("int(11)")
                .HasColumnName("typeid");
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("site");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(500)
                .HasDefaultValueSql("'0'")
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("city");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.District)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("district");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Facebook)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("facebook");
            entity.Property(e => e.Favicon)
                .HasMaxLength(250)
                .HasColumnName("favicon");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("fax");
            entity.Property(e => e.Instagram)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("instagram");
            entity.Property(e => e.Keywords)
                .HasColumnType("text")
                .HasColumnName("keywords");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("linkedin");
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .HasColumnName("logo");
            entity.Property(e => e.Logo2)
                .HasMaxLength(250)
                .HasColumnName("logo2");
            entity.Property(e => e.Maps)
                .HasMaxLength(500)
                .HasColumnName("maps");
            entity.Property(e => e.Mobile)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Page)
                .HasColumnType("int(11)")
                .HasColumnName("page");
            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("phone");
            entity.Property(e => e.Postcode)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .HasColumnName("postcode");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Twitter)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("twitter");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.Youtube)
                .HasMaxLength(250)
                .HasDefaultValueSql("'0'")
                .HasColumnName("youtube");
        });

        modelBuilder.Entity<Slide>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("slide");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Order)
                .HasColumnType("int(11)")
                .HasColumnName("order");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(250)
                .HasColumnName("subtitle");
            entity.Property(e => e.Target)
                .HasMaxLength(50)
                .HasColumnName("target");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
        });

        modelBuilder.Entity<Subscribe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("subscribe");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Work>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("work");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Catid)
                .HasColumnType("int(11)")
                .HasColumnName("catid");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Like)
                .HasColumnType("int(11)")
                .HasColumnName("like");
            entity.Property(e => e.Read)
                .HasColumnType("int(11)")
                .HasColumnName("read");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(500)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        modelBuilder.Entity<Workcat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("workcat");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Detail).HasColumnName("detail");
            entity.Property(e => e.Image)
                .HasMaxLength(250)
                .HasColumnName("image");
            entity.Property(e => e.Isview).HasColumnName("isview");
            entity.Property(e => e.Subtitle)
                .HasMaxLength(500)
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
