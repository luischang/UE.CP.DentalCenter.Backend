using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using UE.CP.DentalCenter.DOMAIN.Core.Entities;

namespace UE.CP.DentalCenter.DOMAIN.Infrastructure.Data
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

        public virtual DbSet<CabFactura> CabFactura { get; set; } = null!;
        public virtual DbSet<CabHistoriaMedica> CabHistoriaMedica { get; set; } = null!;
        public virtual DbSet<CabMedico> CabMedico { get; set; } = null!;
        public virtual DbSet<CabRecetaMedica> CabRecetaMedica { get; set; } = null!;
        public virtual DbSet<Cita> Cita { get; set; } = null!;
        public virtual DbSet<DetFactura> DetFactura { get; set; } = null!;
        public virtual DbSet<DetHistoriaMedica> DetHistoriaMedica { get; set; } = null!;
        public virtual DbSet<DetMedico> DetMedico { get; set; } = null!;
        public virtual DbSet<DetRecetaMedica> DetRecetaMedica { get; set; } = null!;
        public virtual DbSet<HorarioDisponible> HorarioDisponible { get; set; } = null!;
        public virtual DbSet<Medicamento> Medicamento { get; set; } = null!;
        public virtual DbSet<Paciente> Paciente { get; set; } = null!;
        public virtual DbSet<PersonalAdm> PersonalAdm { get; set; } = null!;
        public virtual DbSet<Tratamiento> Tratamiento { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = LAPTOP-UHECV48E; Database = DentalCenterV2; User = sa; Password = 123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CabFactura>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("CAB_FACTURA");

                entity.Property(e => e.IdFactura)
                    .ValueGeneratedNever()
                    .HasColumnName("idFactura");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHora");

                entity.Property(e => e.IdCita).HasColumnName("idCita");

                entity.Property(e => e.IdDetFactura).HasColumnName("idDetFactura");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.Property(e => e.PrecioTotal).HasColumnName("precioTotal");

                entity.HasOne(d => d.IdDetFacturaNavigation)
                    .WithMany(p => p.CabFactura)
                    .HasForeignKey(d => d.IdDetFactura)
                    .HasConstraintName("FK_DET_FACTURA");
            });

            modelBuilder.Entity<CabHistoriaMedica>(entity =>
            {
                entity.HasKey(e => e.IdHistoriaMedica)
                    .HasName("PK_HISTORIA_MEDICA");

                entity.ToTable("CAB_HISTORIA_MEDICA");

                entity.Property(e => e.IdHistoriaMedica)
                    .ValueGeneratedNever()
                    .HasColumnName("idHistoriaMedica");

                entity.Property(e => e.FechaDeActualizacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaDeActualizacion");

                entity.Property(e => e.IdDetHistoriaMedica).HasColumnName("idDetHistoriaMedica");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.HasOne(d => d.IdDetHistoriaMedicaNavigation)
                    .WithMany(p => p.CabHistoriaMedica)
                    .HasForeignKey(d => d.IdDetHistoriaMedica)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.CabHistoriaMedica)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_CAB_HISTORIA_MEDICA_DET_HISTORIA_MEDICA");
            });

            modelBuilder.Entity<CabMedico>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.ToTable("CAB_MEDICO");

                entity.Property(e => e.IdMedico)
                    .ValueGeneratedNever()
                    .HasColumnName("idMedico");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .HasColumnName("apellido");

                entity.Property(e => e.Genero)
                    .HasMaxLength(10)
                    .HasColumnName("genero");

                entity.Property(e => e.IdDetMedico).HasColumnName("idDetMedico");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre");

                entity.HasOne(d => d.IdDetMedicoNavigation)
                    .WithMany(p => p.CabMedico)
                    .HasForeignKey(d => d.IdDetMedico)
                    .HasConstraintName("FK_CAB_MEDICO");
            });

            modelBuilder.Entity<CabRecetaMedica>(entity =>
            {
                entity.HasKey(e => e.IdRecetaMedica);

                entity.ToTable("CAB_RECETA_MEDICA");

                entity.Property(e => e.IdRecetaMedica)
                    .ValueGeneratedNever()
                    .HasColumnName("idRecetaMedica");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdDetRecetaMedica).HasColumnName("idDetRecetaMedica");

                entity.Property(e => e.NombreDeClinica)
                    .HasMaxLength(30)
                    .HasColumnName("nombreDeClinica");

                entity.HasOne(d => d.IdDetRecetaMedicaNavigation)
                    .WithMany(p => p.CabRecetaMedica)
                    .HasForeignKey(d => d.IdDetRecetaMedica)
                    .HasConstraintName("FK_CAB_RECETA_MEDICA");
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita);

                entity.ToTable("CITA");

                entity.Property(e => e.IdCita)
                    .ValueGeneratedNever()
                    .HasColumnName("idCita");

                entity.Property(e => e.Estado)
                    .HasMaxLength(30)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaHora)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaHora");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.IdPaciente).HasColumnName("idPaciente");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_CITA_MEDICO");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_CITA_PACIENTE");
            });

            modelBuilder.Entity<DetFactura>(entity =>
            {
                entity.HasKey(e => e.IdDetFactura);

                entity.ToTable("DET_FACTURA");

                entity.Property(e => e.IdDetFactura)
                    .ValueGeneratedNever()
                    .HasColumnName("idDetFactura");

                entity.Property(e => e.IdRecetaMedica).HasColumnName("idRecetaMedica");

                entity.Property(e => e.IdTratamiento).HasColumnName("idTratamiento");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.HasOne(d => d.IdRecetaMedicaNavigation)
                    .WithMany(p => p.DetFactura)
                    .HasForeignKey(d => d.IdRecetaMedica)
                    .HasConstraintName("FK_DET_FACTURA_CAB_RECETA");

                entity.HasOne(d => d.IdTratamientoNavigation)
                    .WithMany(p => p.DetFactura)
                    .HasForeignKey(d => d.IdTratamiento)
                    .HasConstraintName("FK_DET_FACTURA_TRATAMIENTO");
            });

            modelBuilder.Entity<DetHistoriaMedica>(entity =>
            {
                entity.HasKey(e => e.IdDetHistoriaMedica);

                entity.ToTable("DET_HISTORIA_MEDICA");

                entity.Property(e => e.IdDetHistoriaMedica)
                    .ValueGeneratedNever()
                    .HasColumnName("idDetHistoriaMedica");

                entity.Property(e => e.IdAsistente).HasColumnName("idAsistente");

                entity.Property(e => e.IdCita).HasColumnName("idCita");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.Property(e => e.IdRecetaMedica).HasColumnName("idRecetaMedica");

                entity.Property(e => e.IdTratamiento).HasColumnName("idTratamiento");

                entity.HasOne(d => d.IdAsistenteNavigation)
                    .WithMany(p => p.DetHistoriaMedica)
                    .HasForeignKey(d => d.IdAsistente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA_PERSONAL_ADM");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.DetHistoriaMedica)
                    .HasForeignKey(d => d.IdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA_CITA");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.DetHistoriaMedica)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA_Medico");

                entity.HasOne(d => d.IdRecetaMedicaNavigation)
                    .WithMany(p => p.DetHistoriaMedica)
                    .HasForeignKey(d => d.IdRecetaMedica)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA_CAB_RECETA_MEDICA");

                entity.HasOne(d => d.IdTratamientoNavigation)
                    .WithMany(p => p.DetHistoriaMedica)
                    .HasForeignKey(d => d.IdTratamiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DET_HISTORIA_MEDICA_TRATAMIENTO");
            });

            modelBuilder.Entity<DetMedico>(entity =>
            {
                entity.HasKey(e => e.IdDetMedico);

                entity.ToTable("DET_MEDICO");

                entity.Property(e => e.IdDetMedico)
                    .ValueGeneratedNever()
                    .HasColumnName("idDetMedico");

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(20)
                    .HasColumnName("especialidad");
            });

            modelBuilder.Entity<DetRecetaMedica>(entity =>
            {
                entity.HasKey(e => e.IdDetRecetaMedica);

                entity.ToTable("DET_RECETA_MEDICA");

                entity.Property(e => e.IdDetRecetaMedica)
                    .ValueGeneratedNever()
                    .HasColumnName("idDetRecetaMedica");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Dosis).HasColumnName("dosis");

                entity.Property(e => e.IdMedicamento).HasColumnName("idMedicamento");

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(10)
                    .HasColumnName("unidadMedida");

                entity.HasOne(d => d.IdMedicamentoNavigation)
                    .WithMany(p => p.DetRecetaMedica)
                    .HasForeignKey(d => d.IdMedicamento)
                    .HasConstraintName("FK_DET_RECETA_MEDICA_MEDICAMENTO");
            });

            modelBuilder.Entity<HorarioDisponible>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HORARIO_DISPONIBLE");

                entity.Property(e => e.Dia)
                    .HasColumnType("date")
                    .HasColumnName("dia");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.HoraFin).HasColumnName("horaFin");

                entity.Property(e => e.HoraIni).HasColumnName("horaIni");

                entity.Property(e => e.IdMedico).HasColumnName("idMedico");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HORARIO_DISPONIBLE_CAB_MEDICO");
            });

            modelBuilder.Entity<Medicamento>(entity =>
            {
                entity.HasKey(e => e.IdMedicamento)
                    .HasName("PK__MEDICAME__42B24C5849B321BD");

                entity.ToTable("MEDICAMENTO");

                entity.Property(e => e.IdMedicamento)
                    .ValueGeneratedNever()
                    .HasColumnName("idMedicamento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(40)
                    .HasColumnName("nombre");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.ToTable("PACIENTE");

                entity.Property(e => e.IdPaciente)
                    .ValueGeneratedNever()
                    .HasColumnName("idPaciente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .HasColumnName("apellido");

                entity.Property(e => e.Correo)
                    .HasMaxLength(40)
                    .HasColumnName("correo");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.FechaDeNac)
                    .HasColumnType("date")
                    .HasColumnName("fechaDeNac");

                entity.Property(e => e.Frecuente).HasColumnName("frecuente");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(18)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<PersonalAdm>(entity =>
            {
                entity.HasKey(e => e.IdAsistente);

                entity.ToTable("PERSONAL_ADM");

                entity.Property(e => e.IdAsistente)
                    .ValueGeneratedNever()
                    .HasColumnName("idAsistente");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(20)
                    .HasColumnName("apellido");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(20)
                    .HasColumnName("nombre");

                entity.Property(e => e.Rol)
                    .HasMaxLength(20)
                    .HasColumnName("rol");
            });

            modelBuilder.Entity<Tratamiento>(entity =>
            {
                entity.HasKey(e => e.IdTratamiento);

                entity.ToTable("TRATAMIENTO");

                entity.Property(e => e.IdTratamiento)
                    .ValueGeneratedNever()
                    .HasColumnName("idTratamiento");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(40)
                    .HasColumnName("descripcion");

                entity.Property(e => e.DuracionDias).HasColumnName("duracionDias");

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Tipo)
                    .HasMaxLength(40)
                    .HasColumnName("tipo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
