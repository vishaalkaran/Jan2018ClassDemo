//** Must create context and entites all together


using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

//under project/ Chinook.Data 
//System.Data.Entity
//Entity Framework from NuGut
#region Additional Namespaces 
using Chinook.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    //only acessable inside this project
    internal partial class ChinookContext : DbContext
    {
        //name holds the name value of your web conneection string
        public ChinookContext() : base("name=ChinookDB")
        {

        }

        //a reference to each table in the database as a virtual data set
        public virtual DbSet<Artist> Artists { get; set; }  //add s to end because it's pural/many
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<MediaType> MediaTypes { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<PlaylistTrack> PlaylistTracks { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .Property(e => e.ReleaseLabel)
                .IsUnicode(false);

            modelBuilder.Entity<Artist>()
                .HasMany(e => e.Albums)
                .WithRequired(e => e.Artist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Customers)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.SupportRepId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.Employee1)
                .HasForeignKey(e => e.ReportsTo);

            modelBuilder.Entity<InvoiceLine>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Playlist>()
                .HasMany(e => e.PlaylistTracks)
                .WithRequired(e => e.Playlist)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Track>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Track>()
                .HasMany(e => e.InvoiceLines)
                .WithRequired(e => e.Track)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Track>()
                .HasMany(e => e.PlaylistTracks)
                .WithRequired(e => e.Track)
                .WillCascadeOnDelete(false);
        }
    }
}
