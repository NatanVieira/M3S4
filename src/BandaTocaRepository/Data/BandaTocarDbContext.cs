

using BandaTocarDomain.Models;
using Microsoft.EntityFrameworkCore;

namespace BandaTocaRepository.Data {

    public class BandaTocarDbContext : DbContext {
        
        public DbSet<BandaTocarModel> BandaTocar {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options){
            options.UseSqlServer("Password:MyStrong@Password,Persist Security Info=True;User ID=sa;Initial Catalog=Banda;Data Source=tcp:localhost,1433");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<BandaTocarModel>()
                        .ToTable("BandaTocar");
            modelBuilder.Entity<BandaTocarModel>()
                        .HasKey("Id");
            modelBuilder.Entity<BandaTocarModel>()
                        .Property(bt => bt.Descricao)
                        .HasMaxLength(200)
                        .IsRequired();
            modelBuilder.Entity<BandaTocarModel>()
                        .Property(bt => bt.NomeMusica)
                        .HasMaxLength(200)
                        .IsRequired();
            modelBuilder.Entity<BandaTocarModel>()
                        .Property(bt => bt.Sequencia)
                        .IsRequired();
        }
    }
}