using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodDiary
{
    public partial class DataBaseFoodDiaryContext : DbContext
    {
        public DataBaseFoodDiaryContext()
        {
        }

        public DataBaseFoodDiaryContext(DbContextOptions<DataBaseFoodDiaryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IngredientDb> IngredientDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; DataBase=DataBaseFoodDiary;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientDb>(entity =>
            {
                entity.ToTable("IngredientDB");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
