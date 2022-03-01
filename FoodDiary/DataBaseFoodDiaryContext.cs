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

        public virtual DbSet<IngredientDB> IngredientDB { get; set; }
        public virtual DbSet<RepastType> RepastType { get; set; }
        public virtual DbSet<Repastes> Repastes { get; set; }
        public virtual DbSet<TableDaysMenu> TableDaysMenu { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; DataBase=DataBaseFoodDiary; Trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientDB>(entity =>
            {
                entity.ToTable("IngredientDB");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<RepastType>(entity =>
            {
                entity.HasKey(e => e.IdRepastType)
                    .HasName("PK__RepastTy__FF81A925A3C213E7");

                entity.Property(e => e.IdRepastType).ValueGeneratedNever();

                entity.Property(e => e.RepastTypeName)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Repastes>(entity =>
            {
                entity.HasKey(e => e.IdRepastes)
                    .HasName("PK__Repastes__1954F91A0A6FBB79");

                entity.Property(e => e.IdRepastes).ValueGeneratedNever();
            });

            modelBuilder.Entity<TableDaysMenu>(entity =>
            {
                entity.HasKey(e => e.IdDate)
                    .HasName("PK__TableDay__F298CC89DF70DED1");

                entity.Property(e => e.IdDate).ValueGeneratedNever();

                entity.Property(e => e.DateDay).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
