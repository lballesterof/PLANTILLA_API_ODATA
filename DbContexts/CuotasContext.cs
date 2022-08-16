using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PLANTILLA_API_ODATA.Models;

#nullable disable

namespace PLANTILLA_API_ODATA.DbContexts
{
    public partial class CuotasContext : DbContext
    {
        public CuotasContext()
        {
        }

        public CuotasContext(DbContextOptions<CuotasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VwMbGetCuotasInmobiliarium> VwMbGetCuotasInmobiliaria { get; set; }

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-G4IU4MQ;Database=dbUSDecide;User Id=sa;Password=Qz0966lb");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<VwMbGetCuotasInmobiliarium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_MB_GET_CUOTAS_INMOBILIARIA");

                entity.Property(e => e.Año).HasColumnName("AÑO");

                entity.Property(e => e.Cuota)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("CUOTA");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("ESTADO");

                entity.Property(e => e.FechaVencimiento)
                    .HasMaxLength(4000)
                    .HasColumnName("FECHA_VENCIMIENTO");

                entity.Property(e => e.Importe)
                    .IsRequired()
                    .HasMaxLength(1042)
                    .IsUnicode(false)
                    .HasColumnName("IMPORTE");

                entity.Property(e => e.Mes)
                    .HasMaxLength(4000)
                    .HasColumnName("MES");

                entity.Property(e => e.NumeroSerie)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_SERIE");

                entity.Property(e => e.Ruc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RUC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
