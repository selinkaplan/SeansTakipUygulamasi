using Microsoft.EntityFrameworkCore;
using System;

namespace SeansTakipUygulamasi
{
    public class AppDbContext : DbContext
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<Seans> Seanslar { get; set; }

        // Db bağlantısı için kullanılacak bağlantı dizesini belirtmek üzere OnConfiguring metodunu override ediyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // SQLite veritabanı kullanılacak. "cinema.db" dosyası, uygulamanın çalıştığı dizinde oluşturulacak.
            optionsBuilder.UseSqlite("Data Source=cinema.db");
        }

        // Model oluşturma aşamasında çağrılır, burada model yapılandırmaları yapılabilir.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Film modeli için yapılandırmalar
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.FilmId);
                entity.Property(e => e.Ad).IsRequired().HasMaxLength(100);
                // İlişkiler ve diğer özellikler tanımlanabilir.
            });

            // Salon modeli için yapılandırmalar
            modelBuilder.Entity<Salon>(entity =>
            {
                entity.HasKey(e => e.SalonId);
                entity.Property(e => e.Ad).IsRequired().HasMaxLength(100);
                entity.Property(e => e.KoltukKapasitesi).IsRequired();
                // İlişkiler ve diğer özellikler tanımlanabilir.
            });

            // Seans modeli için yapılandırmalar
            modelBuilder.Entity<Seans>(entity =>
            {
                entity.HasKey(e => e.SeansId);
                entity.Property(e => e.TarihSaat).IsRequired();

                // Film ile Seans arasında bire çok ilişki
                entity.HasOne(d => d.Film)
                      .WithMany(p => p.Seanslar)
                      .HasForeignKey(d => d.FilmId)
                      .OnDelete(DeleteBehavior.Restrict); // Cascade delete önlemek için

                // Salon ile Seans arasında bire çok ilişki
                entity.HasOne(d => d.Salon)
                      .WithMany(p => p.Seanslar)
                      .HasForeignKey(d => d.SalonId)
                      .OnDelete(DeleteBehavior.Restrict); // Cascade delete önlemek için
            });
        }
    }
}
