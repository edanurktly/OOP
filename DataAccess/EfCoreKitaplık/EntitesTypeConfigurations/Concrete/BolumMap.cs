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
    public class BolumMap : BaseMap<Bolum, Guid>
    {

        public override void Configure(EntityTypeBuilder<Bolum> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.BolumAdi).HasMaxLength(50);


        }
    }
}
