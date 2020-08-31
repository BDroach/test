using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace core
{
    public partial class midtermContext : DbContext
    {
        public midtermContext()
        {
        }

        public midtermContext(DbContextOptions<midtermContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCharacters> TCharacters { get; set; }
        public virtual DbSet<TChats> TChats { get; set; }
        public virtual DbSet<TItem> TItem { get; set; }
        public virtual DbSet<TMembers> TMembers { get; set; }
        public virtual DbSet<TMonsters> TMonsters { get; set; }
        public virtual DbSet<TOrders> TOrders { get; set; }
        public virtual DbSet<TProducts> TProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:test2020083117.database.windows.net,1433;Initial Catalog=midterm;Persist Security Info=False;User ID=BDroach;Password=***;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCharacters>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tCharact__D9F8227C01A83B49");

                entity.ToTable("tCharacters");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FAtt).HasColumnName("fAtt");

                entity.Property(e => e.FExp).HasColumnName("fExp");

                entity.Property(e => e.FGold).HasColumnName("fGold");

                entity.Property(e => e.FHp).HasColumnName("fHp");

                entity.Property(e => e.FLevel).HasColumnName("fLevel");

                entity.Property(e => e.FMana).HasColumnName("fMana");

                entity.Property(e => e.FMaxHp).HasColumnName("fMaxHp");

                entity.Property(e => e.FMaxMana).HasColumnName("fMaxMana");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberId");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPath)
                    .HasColumnName("fPath")
                    .HasMaxLength(50);

                entity.Property(e => e.FSteps).HasColumnName("fSteps");
            });

            modelBuilder.Entity<TChats>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tChats__D9F8227C8E8EE0C7");

                entity.ToTable("tChats");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FLike).HasColumnName("fLike");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberId");

                entity.Property(e => e.FPath)
                    .HasColumnName("fPath")
                    .HasMaxLength(50);

                entity.Property(e => e.FTitle)
                    .HasColumnName("fTitle")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TItem>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tItem__D9F8227C36954BD9");

                entity.ToTable("tItem");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberId");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FNumbers).HasColumnName("fNumbers");
            });

            modelBuilder.Entity<TMembers>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tMembers__D9F8227CA1549176");

                entity.ToTable("tMembers");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FAccount)
                    .HasColumnName("fAccount")
                    .HasMaxLength(50);

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FNickName)
                    .HasColumnName("fNickName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPassword)
                    .HasColumnName("fPassword")
                    .HasMaxLength(50);

                entity.Property(e => e.FPath)
                    .HasColumnName("fPath")
                    .HasMaxLength(100);

                entity.Property(e => e.FType).HasColumnName("fType");
            });

            modelBuilder.Entity<TMonsters>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tMonster__D9F8227C8F4B89E3");

                entity.ToTable("tMonsters");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FAtt).HasColumnName("fAtt");

                entity.Property(e => e.FExp).HasColumnName("fExp");

                entity.Property(e => e.FGold).HasColumnName("fGold");

                entity.Property(e => e.FHp).HasColumnName("fHp");

                entity.Property(e => e.FMana).HasColumnName("fMana");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPath)
                    .HasColumnName("fPath")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TOrders>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tOrders__D9F8227CCCBDE590");

                entity.ToTable("tOrders");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FMemberId).HasColumnName("fMemberId");

                entity.Property(e => e.FNumbers).HasColumnName("fNumbers");

                entity.Property(e => e.FProductId).HasColumnName("fProductId");
            });

            modelBuilder.Entity<TProducts>(entity =>
            {
                entity.HasKey(e => e.FId)
                    .HasName("PK__tProduct__D9F8227C5C696ED0");

                entity.ToTable("tProducts");

                entity.Property(e => e.FId).HasColumnName("fId");

                entity.Property(e => e.FName)
                    .HasColumnName("fName")
                    .HasMaxLength(50);

                entity.Property(e => e.FPath)
                    .HasColumnName("fPath")
                    .HasMaxLength(50);

                entity.Property(e => e.FPrice).HasColumnName("fPrice");

                entity.Property(e => e.FQty).HasColumnName("fQty");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
