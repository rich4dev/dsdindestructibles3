namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DsdModel")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<MotivoSolicitud> MotivoSolicitud { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<SolicitudServicio> SolicitudServicio { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Terminal> Terminal { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Mercaderia> Mercaderia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Ruc)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MotivoSolicitud>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoSolicitud>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.SerieFisicoAtn)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.SerieVirtualAtn)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.Capacitado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.CapacitadoNombres)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.CapacitadoCargo)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.Senalizado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.SenalizadoDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudServicio>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.Comunicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Terminal>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.NumeroDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
