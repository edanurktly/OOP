using EfCoreKitaplık.EntitesTypeConfigurations.Abstract;
using EfCoreKitaplık.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreKitaplık.EntitesTypeConfigurations.Concrete
{
    public class YazarMap : BaseMap<Yazar, Guid>
    {
        public override void Configure(EntityTypeBuilder<Yazar> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Ad).HasMaxLength(20);
            builder.Property(x => x.Soyad).HasMaxLength(20);

        }
    }
}
