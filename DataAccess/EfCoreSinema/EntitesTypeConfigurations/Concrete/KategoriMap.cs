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
    public class KategoriMap:BaseMap<Kategori,Guid>
    {
        public override void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.Property(p=>p.KategoriAdi).HasMaxLength(30);
            base.Configure(builder);
        }
    }
}
