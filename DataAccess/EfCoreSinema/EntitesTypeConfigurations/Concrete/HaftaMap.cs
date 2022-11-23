using EfCoreSinema.Entites.Concrete;
using EfCoreSinema.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.EntitesTypeConfigurations.Concrete
{
    public class HaftaMap:BaseMap<Hafta, Guid>
    {
        public override void Configure(EntityTypeBuilder<Hafta> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.HaftaAdi).HasMaxLength(50);
            builder.Property(p => p.HaftaBaslangicTarihi).HasColumnType("datetime")
                .IsRequired(false);
            builder.Property(p => p.HaftaBitisTarihi).HasColumnType("datetime")
              .IsRequired(false);
        }
    }
}
