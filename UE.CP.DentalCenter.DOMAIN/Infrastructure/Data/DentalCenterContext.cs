using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.data
{
    public partial class DentalCenterContext : DbContext
    {
        public DentalCenterContext()
        {
        }

        public DentalCenterContext(DbContextOptions<DentalCenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archivo> Archivo { get; set; } = null!;
        public virtual DbSet<Cita> Cita { get; set; } = null!;
        public virtual DbSet<HistoriaClinica> HistoriaClinica { get; set; } = null!;
        public virtual DbSet<Odontograma> Odontograma { get; set; } = null!;
        public virtual DbSet<OdontogramaObservacion> OdontogramaObservacion { get; set; } = null!;
        public virtual DbSet<Receta> Receta { get; set; } = null!;
        public virtual DbSet<Tratamiento> Tratamiento { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=DentalCenter;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Archivo>(entity =>
            {
                entity.Property(e => e.Formato).HasMaxLength(10);

                entity.Property(e => e.Nombre).HasMaxLength(200);

                entity.HasOne(d => d.HistoriaClinica)
                    .WithMany(p => p.Archivo)
                    .HasForeignKey(d => d.HistoriaClinicaId)
                    .HasConstraintName("FK_Archivo_HistoriaClinica");
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.FechaYhora)
                    .HasColumnType("datetime")
                    .HasColumnName("FechaYHora");

                entity.Property(e => e.Materno).HasMaxLength(100);

                entity.Property(e => e.Nombres).HasMaxLength(100);

                entity.Property(e => e.Paterno).HasMaxLength(100);

                entity.Property(e => e.Teléfono).HasMaxLength(100);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Cita_Usuario");
            });

            modelBuilder.Entity<HistoriaClinica>(entity =>
            {
                entity.Property(e => e.FechaAtencion).HasColumnType("datetime");

                entity.HasOne(d => d.UsuarioMedico)
                    .WithMany(p => p.HistoriaClinicaUsuarioMedico)
                    .HasForeignKey(d => d.UsuarioMedicoId)
                    .HasConstraintName("FK_HistoriaClinica_Usuario1");

                entity.HasOne(d => d.UsuarioPaciente)
                    .WithMany(p => p.HistoriaClinicaUsuarioPaciente)
                    .HasForeignKey(d => d.UsuarioPacienteId)
                    .HasConstraintName("FK_HistoriaClinica_Usuario");
            });

            modelBuilder.Entity<Odontograma>(entity =>
            {
                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Odontograma)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Odontograma_Usuario");
            });

            modelBuilder.Entity<OdontogramaObservacion>(entity =>
            {
                entity.HasOne(d => d.Odontograma)
                    .WithMany(p => p.OdontogramaObservacion)
                    .HasForeignKey(d => d.OdontogramaId)
                    .HasConstraintName("FK_OdontogramaObservacion_Odontograma");
            });

            modelBuilder.Entity<Receta>(entity =>
            {
                entity.Property(e => e.Dosis).HasMaxLength(50);

                entity.Property(e => e.Intervalo).HasMaxLength(20);

                entity.Property(e => e.Medicamento).HasMaxLength(100);

                entity.HasOne(d => d.HistoriaClinica)
                    .WithMany(p => p.Receta)
                    .HasForeignKey(d => d.HistoriaClinicaId)
                    .HasConstraintName("FK_Receta_HistoriaClinica");
            });

            modelBuilder.Entity<Tratamiento>(entity =>
            {
                entity.Property(e => e.Presupuesto).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.HistoriaClinica)
                    .WithMany(p => p.Tratamiento)
                    .HasForeignKey(d => d.HistoriaClinicaId)
                    .HasConstraintName("FK_Tratamiento_HistoriaClinica1");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Contrasena).HasMaxLength(100);

                entity.Property(e => e.Correo).HasMaxLength(100);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Estado)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Materno).HasMaxLength(100);

                entity.Property(e => e.Nombres).HasMaxLength(100);

                entity.Property(e => e.Paterno).HasMaxLength(100);

                entity.Property(e => e.Teléfono).HasMaxLength(100);

                entity.Property(e => e.TipoUsuario).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
