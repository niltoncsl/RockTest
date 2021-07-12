using Like.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Like.Repository.Context
{
    public partial class LikeContext : DbContext
    {
        public LikeContext()
        {
        }

        public LikeContext(DbContextOptions<LikeContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleHistory> ArticleHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.ToTable("Article");
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Name).IsRequired().HasMaxLength(150);
                entity.Property(a => a.Total).IsRequired();

            });
            modelBuilder.Entity<ArticleHistory>(entity =>
            {
                entity.ToTable("ArticleHistory");
                entity.HasKey(ah => ah.Id);
                entity.HasOne(ah => ah.Article).WithMany(a=> a.ArticleHistory).HasForeignKey(p => p.IdArticle);
                entity.Property(ah => ah.DateCreation).IsRequired();
                entity.Property(ah => ah.Ip).IsRequired();

            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
