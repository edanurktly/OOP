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
    public class SeansMap:BaseMap<Seans, Guid>
    {
        public override void Configure(EntityTypeBuilder<Seans> builder)
        {
            builder.Property(p => p.Saat);
            base.Configure(builder);
        }
    }
}
