using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XGame.Domain.Entities;

namespace XGame.Infrastructure.Persistences {
    public class XGameContext : DbContext {
        public XGameContext():base("XGameConnectionString") {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Player> Players { get; set; }
        public IDbSet<Plataform> Plataforms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            // Seta o Schema default
            // modelBuilder.HasDefaultSchema("Apoio");
            // Remove a pluralização dos nomes das tables
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Remove eclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Setar para usar varcgar ao invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            // Caso eu esqueça de informar o tamanho do campo ele irá colocar varchar 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            // Mapeia as entidades
            // modelBuilder.Conventions.Add(new PlayerMap());
            // modelBuilder.Conventions.Add(new PlataformMap());

            #region Adiciona entidades mapeadas - automaticamente via Assembly
                modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
