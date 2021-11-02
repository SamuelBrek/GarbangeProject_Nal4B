using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Garbange.Domain.Entities;

#nullable disable

namespace Garbange.Infraestructure.Data
{
    public partial class Garbange4BContext : DbContext
    {
        public Garbange4BContext()
        {
        }

        public Garbange4BContext(DbContextOptions<Garbange4BContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Denuncium> Denuncia { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Registro> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=Garbange4B.mssql.somee.com;Initial Catalog=Garbange4B;Persist Security Info=False;User ID=SamuelBrekMS_SQLLogin_2;Password=x7c25ir7pn");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Denuncium>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ColoniaDenuncia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coloniaDenuncia");

                entity.Property(e => e.DescripcionDenuncia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcionDenuncia");

                entity.Property(e => e.FechaDenuncia)
                    .HasColumnType("date")
                    .HasColumnName("fechaDenuncia");

                entity.Property(e => e.IdDenuncia)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idDenuncia");

                entity.Property(e => e.ImagenDenuncia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imagenDenuncia");

                entity.Property(e => e.MotivoDenuncia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("motivoDenuncia");

                entity.Property(e => e.UbicacionDenuncia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubicacionDenuncia");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Evento");

                entity.Property(e => e.DescripcionEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcionEvento");

                entity.Property(e => e.FechaEvento)
                    .HasColumnType("date")
                    .HasColumnName("fechaEvento");

                entity.Property(e => e.HoraEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("horaEvento");

                entity.Property(e => e.IdEvento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idEvento");

                entity.Property(e => e.ImagenEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imagenEvento");

                entity.Property(e => e.NombreEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreEvento");

                entity.Property(e => e.PersonasEvento).HasColumnName("personasEvento");

                entity.Property(e => e.UbicacionEvento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ubicacionEvento");
            });

            modelBuilder.Entity<Registro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REGISTRO");

                entity.Property(e => e.ApellidoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellidoUsuario");

                entity.Property(e => e.ContrasenaUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contrasenaUsuario");

                entity.Property(e => e.CorreoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("correoUsuario");

                entity.Property(e => e.FechanacUsuario)
                    .HasColumnType("date")
                    .HasColumnName("fechanacUsuario");

                entity.Property(e => e.IdRegistro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("idRegistro");

                entity.Property(e => e.NicknameUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nicknameUsuario");

                entity.Property(e => e.NivelUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nivelUsuario");

                entity.Property(e => e.NombreUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombreUsuario");

                entity.Property(e => e.TelefonoUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefonoUsuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
