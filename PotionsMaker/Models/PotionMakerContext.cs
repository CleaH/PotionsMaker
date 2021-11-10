using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PotionsMaker.Models
{
    public partial class PotionMakerContext : DbContext
    {
        public PotionMakerContext()
        {
        }

        public PotionMakerContext(DbContextOptions<PotionMakerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = PotionMaker; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<Ingredient>(entity =>
            {
                entity.ToTable("Ingredient");

                entity.Property(e => e.IngredientId).HasColumnName("ingredient_id");

                entity.Property(e => e.Agilite).HasColumnName("agilite");

                entity.Property(e => e.Amour).HasColumnName("amour");

                entity.Property(e => e.DescriptionIngredient)
                    .HasColumnType("text")
                    .HasColumnName("descriptionIngredient");

                entity.Property(e => e.ImageIngredient)
                    .HasColumnType("image")
                    .HasColumnName("imageIngredient");

                entity.Property(e => e.Intelligence).HasColumnName("intelligence");

                entity.Property(e => e.Mana).HasColumnName("mana");

                entity.Property(e => e.Nom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom");

                entity.Property(e => e.Puissance).HasColumnName("puissance");

                entity.Property(e => e.Soin).HasColumnName("soin");

                entity.Property(e => e.TauxReussite)
                    .HasColumnType("decimal(2, 1)")
                    .HasColumnName("taux_reussite");

                entity.Property(e => e.Toxicity).HasColumnName("toxicity");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
