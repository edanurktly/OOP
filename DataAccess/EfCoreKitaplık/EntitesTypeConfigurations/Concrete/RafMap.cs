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
    public class RafMap : BaseMap<Raf, Guid>
    {

        public override void Configure(EntityTypeBuilder<Raf> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.RafNo).HasMaxLength(50);


        }
    }
}
