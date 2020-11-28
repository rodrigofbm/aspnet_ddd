using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infrastructure.Persistences.Map {
    public class PlataformMap : EntityTypeConfiguration<Plataform> {
        public PlataformMap() {
            Property(p => p.Name).HasMaxLength(50).IsRequired();
        }
    }
}
