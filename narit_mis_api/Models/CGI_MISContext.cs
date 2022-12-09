using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace narit_mis_api.Models
{
    public partial class CGI_MISContext : DbContext
    {
        public CGI_MISContext()
        {
        }

        public CGI_MISContext(DbContextOptions<CGI_MISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.2.176,49176;Database=CGI_MIS;User ID=admin;Password=Aa!12345;Trusted_Connection=false ;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<staff>(entity =>
            {
                entity.ToTable("Staff");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
