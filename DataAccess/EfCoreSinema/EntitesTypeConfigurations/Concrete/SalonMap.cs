using EfCoreSinema.Entites.Concrete;
using EfCoreSinema.EntitesTypeConfigurations.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreSinema.EntitesTypeConfigurations.Concrete
{
    public class SalonMap:BaseMap<Salon, Guid>
    {
        public override void Configure(EntityTypeBuilder<Salon> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SalonAdi)
                .HasMaxLength(50);

        }
    }
}
