using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services.Database;

public partial class ECinemaContext : DbContext
{
    public ECinemaContext()
    {
    }

    public ECinemaContext(DbContextOptions<ECinemaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MoviePersonnel> MoviePersonnel { get; set; }

    public virtual DbSet<Personnel> Personnel { get; set; }

    public virtual DbSet<Projection> Projections { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=eCinema; Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(entity =>
        {
            entity.ToTable("City");

            entity.Property(e => e.Id).HasMaxLength(50);
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("Genre");

            entity.Property(e => e.Id).HasMaxLength(50);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.CityId).HasMaxLength(50);

            entity.HasOne(d => d.City).WithMany(p => p.Locations)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Location_City");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movie");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.GenreId).HasMaxLength(50);

            entity.HasOne(d => d.Genre).WithMany(p => p.Movies)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Movie_Genre");
        });

        modelBuilder.Entity<MoviePersonnel>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.MovieId).HasMaxLength(50);
            entity.Property(e => e.PersonnelId).HasMaxLength(50);

            entity.HasOne(d => d.Movie).WithMany(p => p.MoviePersonnel)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MoviePersonnel_Movie");

            entity.HasOne(d => d.Personnel).WithMany(p => p.MoviePersonnel)
                .HasForeignKey(d => d.PersonnelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MoviePersonnel_Personnel");
        });

        modelBuilder.Entity<Personnel>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(50);
        });

        modelBuilder.Entity<Projection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Projection");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.MovieId).HasMaxLength(50);
            entity.Property(e => e.RoomId).HasMaxLength(50);

            entity.HasOne(d => d.Movie).WithMany()
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projection_Movie");

            entity.HasOne(d => d.Room).WithMany()
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projection_Room");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.ToTable("Room");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.LocationId).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.Location).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Room_Location");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
